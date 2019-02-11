using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint1;

namespace UnitTestFlyingVehicle
{
    [TestClass]
    public class UnitTestDrone
    {
        [TestMethod]
        public void TestDroneConstructor()
        {
            //arrange
            Drone d = new Drone();

            //assert
            Assert.AreEqual(500, d.MaxAltitude);
        }
    }
}
