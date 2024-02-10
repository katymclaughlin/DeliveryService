using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliveryService.Data;
using DeliveryService.Repository;

namespace DeliveryService.Tests
{
    [TestClass]
    public class DeliveryService_Tests
    {
        [TestMethod]

        public void TestMethod1()
        {
            Delivery myDelivery = new Delivery();
            myDelivery.OrderName = "Shoes";
            myDelivery.ItemQuantity = 2;
            myDelivery.ItemNumber = 3344;
            myDelivery.DeliveryStatus = "canceled";
            myDelivery.OrderDate = "03/11/2023";

            Assert.AreEqual("Shoes", myDelivery.OrderName);
            Assert.AreEqual(3, myDelivery.ItemQuantity);
            Assert.AreEqual(3344, myDelivery.ItemQuantity);
            Assert.AreEqual("Canceled", myDelivery.DeliveryStatus);
            Assert.AreEqual("03/11/2023", myDelivery.OrderDate);

        }
    }
}