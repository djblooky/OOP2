using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint1;

namespace UnitTestFlyingVehicle
{
    [TestClass]
    public class UnitTestHelicopter
    {
        [TestMethod]
        public void TestHelicopterConstructor()
        {
            //arrange
            Helicopter h = new Helicopter();

            //assert
            Assert.AreEqual(8000, h.MaxAltitude);
        }
    }
}
