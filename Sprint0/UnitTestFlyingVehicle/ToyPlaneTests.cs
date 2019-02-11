using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint0;

namespace UnitTestFlyingVehicle
{
    [TestClass]
    public class ToyPlaneTests
    {
        ToyPlane t;

        [TestMethod]
        public void TestToyPlaneConstructor()
        {
            //arrange
            t = new ToyPlane();

            //assert
            Assert.AreEqual(50, t.MaxAltitude); //toyplanes should have max alt of 50 default
            Assert.AreEqual(false, t.isWoundUP);
        }

        [TestMethod]
        public void TestToyPlaneAbout()
        {
            //arrange
            t = new ToyPlane();

            //assert
            Assert.AreEqual(t.getWindUpString() + "\n" +
                t.getEngineStartedString() + "\nThis " + t +
                " has a max altitude of " + t.MaxAltitude + "\nIt's current altitude is " + t.CurrentAltitude, t.About());
        }

        [TestMethod]
        public void TestGetWindUpString()
        {
            //arrange
            t = new ToyPlane();

            //assert
            Assert.AreEqual(t + " is not wound up.", t.getWindUpString());
        }

        [TestMethod]
        public void TestStartEngine()
        {
            //arrange
            t = new ToyPlane();

            //act
            t.isWoundUP = true;
            t.StartEngine();

            //assert
            Assert.AreEqual(true, t.Engine.IsStarted); //engine should start after plane is wound
        }

        [TestMethod]
        public void TestTakeOff()
        {
            //arrange
            t = new ToyPlane();

            //assert
            Assert.AreEqual(t + " can't fly, it isn't wound up!", t.TakeOff()); //default string
        }

        [TestMethod]
        public void TestUnwind()
        {
            //arrange
            t = new ToyPlane();

            //act
            t.isWoundUP = true; //wound up beings as true
            bool originalIsWoundUp = t.isWoundUP; 
            t.UnWind();

            //assert
            Assert.AreNotEqual(originalIsWoundUp, t.isWoundUP); //should no longer be the same
        }

        [TestMethod]
        public void TestWindup()
        {
            //arrange
            t = new ToyPlane();

            //act
            bool originalIsWoundUp = t.isWoundUP; //begins as false (tested in constructor)
            t.WindUp();

            //assert
            Assert.AreNotEqual(originalIsWoundUp, t.isWoundUP); //should no longer be the same
        }
    }
}