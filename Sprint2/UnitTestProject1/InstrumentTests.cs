using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint2;

namespace InstrumentTests
{
    [TestClass]
    public abstract class InstrumentTests
    {
        InstrumentTestClass i; //cant create an instance of the abstract class instrument

        [TestMethod]
        public virtual void TestAbout()
        {
            i = new InstrumentTestClass();

            Assert.AreEqual($"This {i.Material} {i} costs ${i.Cost} and makes a {i.Sound} sound. \n{i.GetIsPlayingString()}", i.About());
        }

        [TestMethod]
        public virtual void TestConstructor()
        {

        }

        [TestMethod]
        public void TestPlay()
        {

        }

        [TestMethod]
        public void TestStopPlaying()
        {

        }

        [TestMethod]
        public void TestGetSound()
        {

        }

        [TestMethod]
        public void TestMakeSound()
        {

        }

        [TestMethod]
        public void TestMakeSound(int HowManyTimes)
        {

        }

        [TestMethod]
        public void TestGetIsPlayingString()
        {

        }
    }
}
