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
        public void TestDogConstructor()
        {
            //arrange
            d = new Dog(); //add using for dog

            //act
            

            //assert
            Assert.AreEqual(1, d.Age); //default age is 1
            Assert.AreEqual(0, d.BarkCount); //default barks 0
            Assert.AreEqual("Fido", d.Name);
            Assert.AreEqual("Woof", d.BarkSound);
            Assert.AreEqual(1, d.Weight);
            Assert.AreEqual(',', d.BarkSplit);
        }

        [TestMethod]
        public void TestDogAbout()
        {
            //arrange
            d = new Dog(); //add using for dog

            //act

            //assert
            Assert.AreEqual($"Hello my name is {d.Name} I'm {d.Age} years old. My bark sounds like {d.BarkSound}. Ive barked {d.BarkCount} times.", d.About());
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
