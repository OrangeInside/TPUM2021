using NUnit.Framework;
using ClientLogic.Services;
using ClientLogic;
using System.Globalization;
using System.Threading.Tasks;
using System;
using System.Runtime;
using System.Reflection;
using System.Collections;

namespace IntegrationTests
{
    public class Tests
    {
        private IConnectionSerivce connectionService;
        private IVinylService vinylService;

        [SetUp]
        public void Setup()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            connectionService = new SrvConnect();
            vinylService = ClientLogic.ServiceFactory.CreateVinylService;

            var task1 = Task.Run(async () => { await ServerPresentation.Program.CreateServer(); });
            var task2 = Task.Run(async () => { await connectionService.Connect(new Uri("ws://localhost:8081/")); });
            task2.Wait();

            var task = Task.Run(async () => ClientData.VinylDataBase.Instance.Refresh());
            task.Wait();           
        }

        [Test]
        public void AddTest()
        {
            int vinylCount = vinylService.GetVinyl(0).inStock;

            vinylService.RemoveVinyl(0, 1);

            Assert.AreEqual(vinylCount - 1, vinylService.GetVinyl(0).inStock);
            Assert.AreEqual(vinylCount - 1, ServerData.VinylDataBase.Instance.Get(0).InStock);

            Assert.IsTrue(true);
        }

        [Test]
        public void GetAllTest()
        {
            //"Burzum"
            Assert.AreEqual("Burzum", vinylService.GetVinyl(0).Band);
            Assert.AreEqual("Burzum", ServerData.VinylDataBase.Instance.Get(0).Band);
            Assert.AreEqual(vinylService.GetVinyl(0).ID, ServerData.VinylDataBase.Instance.Get(0).ID);
            Assert.AreEqual(vinylService.GetVinyl(0).Band, ServerData.VinylDataBase.Instance.Get(0).Band);
            Assert.AreEqual(vinylService.GetVinyl(0).Title, ServerData.VinylDataBase.Instance.Get(0).Title);
        }
    }
}