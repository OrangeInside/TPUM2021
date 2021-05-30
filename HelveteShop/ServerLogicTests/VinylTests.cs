using NUnit.Framework;
using ServerData;
using ServerLogic;
using CommonModel;
using Moq;


namespace ServerLogicTests
{
    public class VinylTests
    {
        private Mock<IVinylDatabase> mockVinylDB;

        private SrvVinyls srvVinyls;

        [SetUp]
        public void Setup()
        {
            mockVinylDB = new Mock<IVinylDatabase>();

            mockVinylDB.Setup(x => x.AddNew(new Vinyl(0, "Cry my name", "Garager Destructionators", 0.99m, 1))).Returns(true);

            mockVinylDB.Setup(x => x.Get(0)).Returns(new Vinyl(0, "Cry my name", "Garager Destructionators", 0.99m, 1));

            mockVinylDB.Setup(x => x.Remove(3)).Returns(true);

            mockVinylDB.Setup(x => x.AddStock(0, 2)).Returns(true);

            mockVinylDB.Setup(x => x.RemoveStock(0, 1)).Returns(true);

            srvVinyls = new SrvVinyls(mockVinylDB.Object);
        }

        [Test]
        public void GetTest()
        {
            Assert.AreEqual("Garager Destructionators", srvVinyls.GetVinyl(0).Result.Band);
            //Assert.AreEqual("Mgla", srvVinyls.GetVinyl(0).Result.Band);
        }

        [Test]
        public void AddTest()
        {
            Assert.AreEqual(0, srvVinyls.GetVinyl(0).Result.ID);
            Assert.AreEqual(true, srvVinyls.AddVinyl(0, 2).Result);
        }

        [Test]
        public void RemoveStockTest()
        {
            Assert.AreEqual(true, srvVinyls.RemoveStockVinyl(0, 1).Result);
        }

        [Test]
        public void RemoveTest()
        {
            Assert.AreEqual(true, srvVinyls.RemoveVinyl(3).Result);
        }
    }
}