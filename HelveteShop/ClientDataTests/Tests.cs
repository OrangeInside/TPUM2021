using System.Linq;
using ClientData;
using NUnit.Framework;


namespace ClientDataTests
{
    public class Tests
    {
        private VinylDataBase vinylDataBase;

        [SetUp]
        public void Setup()
        {
            DataContext.Instance.Vinyls.Clear();
            DataContext.Instance.Vinyls.Add(new Vinyl(0, "Album0", "Band0", 1.1m, 8));
            DataContext.Instance.Vinyls.Add(new Vinyl(1, "Album1", "Band1", 5.1m, 3));
            DataContext.Instance.Vinyls.Add(new Vinyl(2, "Album2", "Band2", 3.3m, 6));

            vinylDataBase = new VinylDataBase();
        }

        [Test]
        public void GetTest()
        {
            Assert.AreEqual(0, vinylDataBase.Get(0).ID);
            Assert.AreEqual("Album1", vinylDataBase.Get(1).Title);
            Assert.AreEqual("Band2", vinylDataBase.Get(2).Band);
            Assert.AreEqual(6, vinylDataBase.Get(2).InStock);

        }

        [Test]
        public void GetAllTest()
        {
            var vinyls = vinylDataBase.GetAll().ToList();
            Assert.AreEqual(3, vinyls.Count);
            Assert.AreEqual(0, vinyls[0].ID);
            Assert.AreEqual(1, vinyls[1].ID);
        }

        [Test]
        public void RemoveTest()
        {
            Assert.AreEqual(true, vinylDataBase.Remove(0));
            var vinyls = vinylDataBase.GetAll().ToList();
            Assert.AreEqual(2, vinyls.Count);
            Assert.AreEqual(1, vinyls[0].ID);
        }
    }
}