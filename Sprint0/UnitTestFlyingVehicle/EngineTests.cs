using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint0;

namespace UnitTestFlyingVehicle
{
    [TestClass]
    public class EngineTests
    {
        Engine e;

        [TestMethod]
        public void TestEngineConstructor()
        {
            //arrange
            e = new Engine();

            //assert
            Assert.AreEqual(false, e.IsStarted); //engine is started default is false
        }

        [TestMethod]
        public void TestEngineAbout()
        {
            //arrange
            e = new Engine();

            //assert
            Assert.AreEqual(e + " is not started", e.About()); //test to see if engine default about is true
        }
    }
}