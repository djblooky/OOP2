using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryFinal;
using ClassLibraryFinal.Vehicles;
using Moq;
using System.Collections.Generic;

namespace UnitTestFinal
{
    [TestClass]
    public class UnitTestDeliveryService
    {
        IShippingVehicle vehicle;
        IDeliveryService delivery;

        public UnitTestDeliveryService()
        {
            
        }

        /// <summary>
        /// Tests defaults for Class
        /// </summary>
        [TestMethod]
        public void DeliveryService_UnclesTruckDefaults()
        {
            //Arrange
            double costPerRefuel = 200;
            vehicle = new Truck();
            delivery = new UnclesTruck(vehicle);
            //Act

            //Assert
            Assert.IsNotNull(delivery);
            Assert.IsNotNull(delivery.ShippingVehicle);
            Assert.AreEqual(delivery.CostPerRefuel, costPerRefuel);
        }

        [TestMethod]
        public void DeliveryService_AirExpressDefaults()
        {
            //Arrange
            double costPerRefuel = 2000;
            vehicle = new Plane();
            delivery = new AirExpress(vehicle);
            //Act

            //Assert
            Assert.IsNotNull(delivery);
            Assert.IsNotNull(delivery.ShippingVehicle);
            Assert.AreEqual(delivery.CostPerRefuel, costPerRefuel);
        }

        [TestMethod]
        public void DeliveryService_SnailServiceDefaults()
        {
            //Arrange
            double costPerRefuel = 2;
            vehicle = new ShippingSnail();
            delivery = new SnailService(vehicle);
            //Act

            //Assert
            Assert.IsNotNull(delivery);
            Assert.IsNotNull(delivery.ShippingVehicle);
            Assert.AreEqual(delivery.CostPerRefuel, costPerRefuel);
        }

        [TestMethod]
        public void MockTest()
        {
            //Arrange
            DefaultShippingService defaultService;

            var mockDeliveryService = new Mock<IDeliveryService>();
            var mockProduct = new Mock<IProduct>();
            var mockShippingLocation = new Mock<IShippingLocation>();

            //Act
            mockDeliveryService.Setup(dS => dS.CostPerRefuel).Equals(5);
            mockDeliveryService.Setup(dS => dS.ShippingVehicle).Equals(new CarrierPigeon());

            mockShippingLocation.Setup(sL => sL.StartZipCode).Equals("101011");
            mockShippingLocation.Setup(sL => sL.DestinationZipCode).Equals("7088");

            mockProduct.Setup(p => p.Name).Equals("Rubik's Cube");
            mockProduct.Setup(p => p.ShippingWeight).Equals(2);
            mockProduct.Setup(p => p.ShortDescription).Equals("A puzzle (in cube form)!");

            List<IProduct> products = new List<IProduct>();
            products.Add(mockProduct.Object);

            defaultService = new DefaultShippingService(mockDeliveryService.Object, products, mockShippingLocation.Object);
            double cost;
            cost = defaultService.ShippingCost();

            //Assert
            Assert.IsInstanceOfType(defaultService.DeliveryService, typeof(IDeliveryService));
            Assert.IsInstanceOfType(defaultService.ShippingLocation, typeof(IShippingLocation));
            Assert.IsInstanceOfType(defaultService.Products, typeof(List<IProduct>));
        }

    }
}
