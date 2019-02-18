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
            i = new InstrumentTestClass();

            Assert.AreEqual(false, i.IsPlaying);
        }

        [TestMethod]
        public void TestPlay() 
        {
            i = new InstrumentTestClass();

            i.Play();

            Assert.AreEqual(true, i.IsPlaying);
            //test call to makesound ?
        }

        [TestMethod]
        public void TestStopPlaying()
        {
            i = new InstrumentTestClass();

            i.StopPlaying();

            Assert.AreEqual(false, i.IsPlaying);
        }

        [TestMethod]
        public void TestGetSound()
        {
            i = new InstrumentTestClass();

            int OriginalSoundCount = i.SoundCount;
            i.GetSound();
            int NewSoundCount = i.SoundCount;

            Assert.AreEqual(NewSoundCount, OriginalSoundCount + 1);
            Assert.AreEqual(i.Sound, i.GetSound());
        }

        [TestMethod]
        public void TestMakeSound()
        {
            i = new InstrumentTestClass();

            Assert.AreEqual(i.MakeSound(3), i.MakeSound());
        }

        [TestMethod]
        public void TestMakeSound(int HowManyTimes) 
        {
            i = new InstrumentTestClass();

            int count = 0;
            string SoundString = "";
            while (count < HowManyTimes)
            {
                SoundString += i.Sound + i.soundSplit;
                count++;
            }         

            Assert.AreEqual(SoundString, i.MakeSound(HowManyTimes));
        }

        [TestMethod]
        public void TestGetIsPlayingString() 
        {
            i = new InstrumentTestClass();

            i.IsPlaying = true;

            Assert.AreEqual(i + " is playing!", i.GetIsPlayingString());

            i.IsPlaying = false;

            Assert.AreEqual(i + " is not playing!", i.GetIsPlayingString());
        }
    }
}
