using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestFlyingVehicle
{
    [TestClass]
    public class EngineTests
    {
        [TestMethod]
        public void EngineIsStarted() //open up test explorer window for green lights
        {
            //arrange
            Engine e = new Engine(); //one engine per class

            //act
            bool defaultEngineStarted = e.IsStarted;

            //assert
            Assert.AreEqual(, true);
        }
    }
}
