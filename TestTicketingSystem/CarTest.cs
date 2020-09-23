using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestTicketingSystem
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void CarPriceTest()
        {
            //Arrange
            Car car = new Car();
            //Act
            var actualPrice = car.Price();
            double expectedPrice = 240;
            //Assert
            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [TestMethod]
        public void CarVehicleTypeTest()
        {
            //Arrange
            Car car = new Car();
            //Act
            var actualVehicleType = car.VehicleType();
            string expectedVehicleType = "Car";
            //Assert
            Assert.AreEqual(expectedVehicleType, actualVehicleType);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception),"License Plate must be maximum 7 characters.")]
        public void MoreThan7LicensePlateTest()
        {
            //Arrange
            Car car = new Car();
            //Act
            string LP = "12345678";
            //Assert
            Assert.AreEqual(LP, car.LicensePlate);
        }

        [TestMethod]
        public void MCPriceTest()
        {
            //Arrange
            MC mc = new MC();
            //Act
            var actualPrice = mc.Price();
            double expectedPrice = 125;
            //Assert
            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [TestMethod]
        public void MCVehicleTypeTest()
        {
            //Arrange
            MC mc = new MC();
            //Act
            var actualVehicleType = mc.VehicleType();
            string expectedVehicleType = "MC";
            //Assert
            Assert.AreEqual(expectedVehicleType, actualVehicleType);
        }
        }
}
