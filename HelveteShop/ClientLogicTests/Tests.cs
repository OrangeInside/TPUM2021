using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientData;
using ClientLogic;
using CommonModel;
using Moq;
using NUnit.Framework;

namespace ClientLogicTests
{
    public class Tests
    {
        private Mock<IDataBase<IVinyl>> vinylsDataBaseMock;
        private VinylService vinylService;

        [SetUp]
        public void Setup()
        {
            vinylsDataBaseMock = new Mock<IDataBase<IVinyl>>();

            vinylsDataBaseMock.Setup(x => x.Get(0)).Returns(new Vinyl(0, "Album0", "Band0", 1.1m, 3));
            vinylsDataBaseMock.Setup(x => x.Get(1)).Returns(new Vinyl(1, "Album1", "Band1", 2.3m, 7));
            vinylsDataBaseMock.Setup(x => x.Get(2)).Returns(new Vinyl(2, "Album2", "Band2", 5.0m, 5));

            vinylsDataBaseMock.Setup(x => x.Get(It.Is<int>(i => i < 0))).Throws<ArgumentOutOfRangeException>();


            vinylsDataBaseMock.Setup(x => x.GetAll()).Returns(new List<IVinyl>()
            {
                new Vinyl(10, "Album10", "Band10", 1.99m, 3),
                new Vinyl(11, "Album11", "Band11", 1.99m, 5),
                new Vinyl(12, "Album12", "Band12", 1.99m, 55),


            });

            vinylService = new VinylService(vinylsDataBaseMock.Object);
        }

        [Test]
        public void TestGet()
        {
            Assert.AreEqual("Album0", vinylService.GetVinyl(0).Title);
            Assert.AreEqual(1, vinylService.GetVinyl(1).ID);

        }

        [Test]
        public void AddVinylsTest()
        {
            Assert.AreEqual(true, vinylService.AddVinyl(new VinylDTO() { inStock = 55, ID = 100, Title = "TestTitle", Band = "TestBand", Price = 1.99m }));
        }

        [Test]
        public void TestGetAll()
        {
            var vinyls = vinylService.GetVinyls().ToList();
            Assert.AreEqual(vinyls.Count, 3);
            Assert.AreEqual(vinyls[0].Title, "Album10");
            Assert.AreEqual(vinyls[1].inStock, 5);
            Assert.AreEqual(vinyls[2].ID, 12);
        }
    }
}