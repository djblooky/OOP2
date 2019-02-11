using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint0;

namespace UnitTestFlyingVehicle
{
    [TestClass]
    public class AirplaneTests
    {
        [TestMethod]
        public void TestAirplaneConstructor()
        {
            //arrange
            Airplane a = new Airplane();

            //assert
            Assert.AreEqual(41000, a.MaxAltitude); //airplanes should have max alt of 41000
        }
    }
}