using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DogInClassSprint1;

namespace UnitTestDogInClass
{
    [TestClass]
    public class UnitTestDog
    {
        [TestMethod]
        public void TestDogHappyBirthday()
        {
            //arrange
            Dog d = new Dog(); //add using for dog

            //act
            int originalAge = d.Age;
            d.HappyBirthday();
            int ageAfterHappyBirthday = d.Age;

            //assert
            Assert.AreEqual(originalAge + 1, ageAfterHappyBirthday); //expected value, actual value
        }
    }
}
