using System;

public class Packer
{
    public static int[] Pack(int[] packSize, int order)
    {
        var packCount = packSize.Length;

        var totalResult = new int[packCount+1,order+1];

        for(var i = 0; i <= order; i++)
            {
                totalResult[0,i] = i;
            }

            for (var i = 1; i <= packCount; i++)
            {
                for (var j = 0; j <= order; j++)
                {
                    if (j < packSize[i-1])
                    {
                        totalResult[i,j] = totalResult[i-1,j];
                    }else
                    {
                        totalResult[i,j] = Math.Min(totalResult[i-1,j], totalResult[i,j-packSize[i-1]]+1);
                    }
                }
            }
            var pc = packCount;
            var ot = order;
            var totalPack = new int[packCount];

            while (totalResult[pc,ot] != 0)
            {
                if (totalResult[pc,ot] == totalResult[pc-1,ot])
                {
                    pc = pc - 1;
                }else
                {
                    ot = ot - packSize[pc-1];
                    totalPack[pc-1] = totalPack[pc-1]+1;
                }
            }
            return totalPack;
    }
}
