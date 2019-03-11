
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sprint4;

namespace UnitTestsCurrency
{
    [TestClass]
    public class PennyTests
    {

        [TestMethod]
        public void PennyConstructor()
        {
            //Arrange
            Penny p, philiPenny;
            //Act 
            p = new Penny();
            philiPenny = new Penny(USCoinMintMark.P);
            //Assert
            Assert.AreEqual(USCoinMintMark.D, p.MintMark);
            Assert.AreEqual(System.DateTime.Now.Year, p.Year);

            Assert.AreEqual(USCoinMintMark.P, philiPenny.MintMark);
        }

        [TestMethod]
        public void PennyMonetaryValue()
        {
            //Arrange
            Penny p;
            //Act 
            p = new Penny();
            //Assert
            Assert.AreEqual(.01, p.MonetaryValue);
        }

        [TestMethod]
        public void PennyAbout()
        {
            //Arrange
            Penny p;
            //Act 
            p = new Penny();
            //Assert
            Assert.AreEqual("US Penny is from 2019. It is worth $0.01. It was made in Denver", p.About());
        }
    }
}
