using NUnit.Framework;
using Data;

namespace Tests
{
    public class DataTests
    {
        IDataBase dataBase;

        [SetUp]
        public void Setup()
        {
            dataBase = new DataBase(new DataFactory());
        }

        [Test]
        public void DataBaseCorrectlyLoaded()
        {
            Assert.IsNotNull(dataBase.GetClient(0));
            Assert.IsNotNull(dataBase.GetVinyl(0));
            Assert.IsNotNull(dataBase.GetOrder(0));

            int vinylsCount = 0;
            foreach(Vinyl vinyl in dataBase.GetAllVinyls())
            {
                vinylsCount++;
            }
            Assert.AreEqual(vinylsCount, 5);

            int clientCount = 0;
            foreach (Client client in dataBase.GetAllClients())
            {
                clientCount++;
            }
            Assert.AreEqual(clientCount, 4);

            int ordersCount = 0;
            foreach (Order order in dataBase.GetAllOrders())
            {
                ordersCount++;
            }
            Assert.AreEqual(ordersCount, 3);

        }

        [Test]
        public void AddingVinyls()
        {
            Vinyl testVinyl = new Vinyl(5, "TestTitle", "TestBand", 3.55M);
            dataBase.AddVinyl(testVinyl);
            Assert.IsNotNull(dataBase.GetVinyl(5));

            int vinylsCount = 0;
            foreach (Vinyl vinyl in dataBase.GetAllVinyls())
            {
                vinylsCount++;
            }
            Assert.AreEqual(vinylsCount, 6);
            Assert.IsFalse(dataBase.AddVinyl(testVinyl));

            vinylsCount = 0;
            foreach (Vinyl vinyl in dataBase.GetAllVinyls())
            {
                vinylsCount++;
            }
            Assert.AreEqual(vinylsCount, 6);
        }

        [Test]
        public void AddingClient()
        {
            Client testClient = new Client(4, "TestName", "TestAddress");
            dataBase.AddClient(testClient);
            Assert.IsNotNull(dataBase.GetClient(4));

            int clientsCount = 0;
            foreach (Client client in dataBase.GetAllClients())
            {
                clientsCount++;
            }
            Assert.AreEqual(clientsCount, 5);
            Assert.IsFalse(dataBase.AddClient(testClient));

            clientsCount = 0;
            foreach (Client client in dataBase.GetAllClients())
            {
                clientsCount++;
            }
            Assert.AreEqual(clientsCount, 5);
        }

        [Test]
        public void AddingOrder()
        {
            Order testOrder = new Order(3, dataBase.GetClient(0), dataBase.GetVinyl(0));
            dataBase.AddOrder(testOrder);
            Assert.IsNotNull(dataBase.GetOrder(3));

            int ordersCount = 0;
            foreach (Order order in dataBase.GetAllOrders())
            {
                ordersCount++;
            }
            Assert.AreEqual(ordersCount, 4);
            Assert.IsFalse(dataBase.AddOrder(testOrder));

            ordersCount = 0;
            foreach (Order order in dataBase.GetAllOrders())
            {
                ordersCount++;
            }
            Assert.AreEqual(ordersCount, 4);
        }
    }
}
