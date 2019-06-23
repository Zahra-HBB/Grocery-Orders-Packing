using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Tests
{
    public class GroceryTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGroceryNotPickingTheBiggestPack()
        {
            var orderTotal= 28;
            var pack = new int[]{4,10,15};
            var totalPack = Packer.Pack(pack,orderTotal);

            Assert.AreEqual(2,totalPack[0]);
            Assert.AreEqual(2,totalPack[1]);
            Assert.AreEqual(0,totalPack[2]);
        }

        [Test]
        public void TestGroceryNotPickingTheSmallestPack()
        {
            var orderTotal= 35;
            var pack = new int[]{5,10,15};
            var totalPack = Packer.Pack(pack,orderTotal);

            Assert.AreEqual(0,totalPack[0]);
            Assert.AreEqual(2,totalPack[1]);
            Assert.AreEqual(1,totalPack[2]);
        }
    }
}