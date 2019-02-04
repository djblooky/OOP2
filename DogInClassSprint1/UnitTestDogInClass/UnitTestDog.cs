using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DogInClassSprint1;

namespace UnitTestDogInClass
{
    [TestClass]
    public class UnitTestDog
    {
        Dog d;

        [TestMethod]
        public void TestDogHappyBirthday()
        {
            //arrange
            d = new Dog(); //add using for dog

            //act
            int originalAge = d.Age;
            d.HappyBirthday();
            int ageAfterHappyBirthday = d.Age;

            //assert
            Assert.AreEqual(originalAge + 1, ageAfterHappyBirthday); //expected value, actual value
        }

        [TestMethod]
        public void TestDogBark()
        {
            //arrange
            d = new Dog();

            //act
            int originalBarks = d.BarkCount;
            string barkSound = d.BarkSound;
            string returnedBarkString = d.Bark();
            int newNumberOfbarks = d.BarkCount;

            int originalMultipleBarkCount = d.BarkCount;
            int BarkTimes = 7;
            string multipleBarkString = d.Bark(BarkTimes);
            int postMultipleBarkCount = d.BarkCount;

            string[] aryMultipleBark = multipleBarkString.Split(d.BarkSplit);

            //assert
            Assert.AreEqual(newNumberOfbarks, originalBarks + 1);
            Assert.AreEqual(barkSound, returnedBarkString);
            Assert.AreEqual(postMultipleBarkCount, originalMultipleBarkCount  + BarkTimes);
            Assert.AreEqual(aryMultipleBark.Length - 1, BarkTimes);
        }
    }
}
