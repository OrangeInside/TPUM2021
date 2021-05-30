using NUnit.Framework;
using ServerData;
using CommonModel;

namespace ServerDataTests
{
    public class VinylTests
    {
        private IVinylDatabase vinylDB;

        [SetUp]
        public void Setup()
        {
            vinylDB = new VinylDataBase();
            vinylDB.AddNew(new Vinyl(0, "A", "a", 1.11m, 1));
            vinylDB.AddNew(new Vinyl(1, "B", "b", 1.22m, 2));
            vinylDB.AddNew(new Vinyl(2, "C", "c", 1.33m, 3));
            vinylDB.AddNew(new Vinyl(3, "D", "d", 1.44m, 4));
        }

        [Test]
        public void AddTest()
        {
            Assert.AreEqual(true, vinylDB.AddNew(new Vinyl(21, "EE", "ee", 2.22m, 5)));          
        }

        [Test]
        public void AddStockTest()
        {
            Assert.AreEqual(true, vinylDB.AddStock(0, 1));
        }

        [Test]
        public void RemoveStockTest()
        {
            Assert.AreEqual(true, vinylDB.RemoveStock(2, 1));
        }

        [Test]
        public void RemoveTest()
        {
            Assert.AreEqual(true, vinylDB.Remove(3));
        }
    }
}