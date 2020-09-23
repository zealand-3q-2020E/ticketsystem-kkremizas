using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestTicketingSystem
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void PriceTest()
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
        public void VehicleTypeTest()
        {
            //Arrange
            Car car = new Car();
            //Act
            var actualVehicleType = car.VehicleType();
            string expectedVehicleType = "Car";
            //Assert
            Assert.AreEqual(expectedVehicleType, actualVehicleType);
        }


    }
}
