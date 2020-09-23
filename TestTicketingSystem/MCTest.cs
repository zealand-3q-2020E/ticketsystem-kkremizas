using Microsoft.VisualStudio.TestTools.UnitTesting;
using  ClassLibrary;

namespace TestTicketingSystem
{
    [TestClass]
    public class MCTest
    {
        [TestMethod]
        public void PriceTest()
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
        public void VehicleTypeTest()
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
