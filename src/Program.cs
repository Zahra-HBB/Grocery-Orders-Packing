using System;

namespace grocery_test
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderTotal= 28;
            var pack = new int[]{4,10,15};
            var totalPack = Packer.Pack(pack,orderTotal);
            
            for (var i = 0; i < pack.Length; i++)
            {            
              Console.WriteLine($"{totalPack[i]} * {pack[i]} ");
            }
        }
    }
}
