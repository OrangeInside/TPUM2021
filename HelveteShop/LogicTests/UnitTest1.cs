using NUnit.Framework;
using Logic;

namespace LogicTests
{
    public class Tests
    {
        IClientsManager clientsManager = null;
        IVinylsManager vinylsManager = null;
        IOrdersManager ordersManager = null;

        [SetUp]
        public void Setup()
        {
            clientsManager = Logic.Logic.GetClientsManager();
            vinylsManager = Logic.Logic.GetVinylsManager();
            ordersManager = Logic.Logic.GetOrdersManager();
        }

        [Test]
        public void TestClientsManagerSetup()
        {
            Assert.IsNotNull(clientsManager);

            Assert.IsNotNull(clientsManager.GetAllClientsAsDTO());
        }

        [Test]
        public void TestAddingClients()
        {
            Assert.IsNotNull(clientsManager);

            Assert.IsNotNull(clientsManager.GetAllClientsAsDTO());

            int expectedClientsCounter = 4;

            Assert.AreEqual(clientsManager.GetAllClientsAsDTO().Count, expectedClientsCounter);

            ClientDTO clientDTO = new ClientDTO() { ID = -1, Name = "test", Address = "test" };

            Assert.IsTrue(clientsManager.AddClient(clientDTO));

            Assert.AreEqual(clientsManager.GetAllClientsAsDTO().Count, expectedClientsCounter + 1);
        }

        [Test]
        public void TestVinylsManagerSetup()
        {
            Assert.IsNotNull(vinylsManager);

            Assert.IsNotNull(vinylsManager.GetAllVinylsAsDTO());
        }

        [Test]
        public void TestAddingVinyls()
        {
            Assert.IsNotNull(vinylsManager);

            Assert.IsNotNull(vinylsManager.GetAllVinylsAsDTO());

            int expectedVinylsCounter = 5;

            Assert.AreEqual(vinylsManager.GetAllVinylsAsDTO().Count, expectedVinylsCounter);

            VinylDTO vinylDTO = new VinylDTO() { ID = -1, Band = "test", Title = "test", Price = 1.99M };

            Assert.IsTrue(vinylsManager.AddVinyl(vinylDTO));

            Assert.AreEqual(vinylsManager.GetAllVinylsAsDTO().Count, expectedVinylsCounter + 1);
        }

        [Test]
        public void TestOrdersManagerSetup()
        {
            Assert.IsNotNull(ordersManager);

            Assert.IsNotNull(ordersManager.GetAllOrdersAsDTO());
        }

        [Test]
        public void TestAddingOrders()
        {
            Assert.IsNotNull(ordersManager);

            Assert.IsNotNull(ordersManager.GetAllOrdersAsDTO());

            int expectedOrdersCounter = 3;

            Assert.AreEqual(ordersManager.GetAllOrdersAsDTO().Count, expectedOrdersCounter);

            OrderDTO orderDTO = new OrderDTO() { ID = -1, ClientID = 0, ClientName = "Odo", ClientAddress = "Milorgveien 121", VinylID = 0, VinylTitle = "Filosofem", VinylBand = "Burzum", VinylPrice = 1.99M };

            Assert.IsTrue(ordersManager.AddOrder(orderDTO));

            Assert.AreEqual(ordersManager.GetAllOrdersAsDTO().Count, expectedOrdersCounter + 1);
        }
    }
}