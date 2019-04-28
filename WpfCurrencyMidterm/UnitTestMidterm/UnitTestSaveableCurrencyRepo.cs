using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WpfCurrencyMidterm.Models;

namespace WpfCurrencyMidterm
{
    [TestClass]
    public class UnitTestSaveableCurrencyRepo
    {
        SaveableCurrencyRepo repo;

        public UnitTestSaveableCurrencyRepo()
        {
            repo = new SaveableCurrencyRepo(
                new List<ICoin>()
                {
                    new Penny(),
                    new Nickel(),
                    new Quarter()
                });
        }

        [TestMethod]
        public void SaveableCurrenyRepo_Saving_DefaultPath()
        {
            //Arrange
            string realPath;
            string defaultPath;

            //Act
            defaultPath = "MyFile.bin";
            realPath = repo.Path;

            //Assert
            Assert.AreEqual(defaultPath, realPath);
        }

        [TestMethod]
        public void SaveableCurrenyRepo_Saving_Load()
        {
            //Arrange
            List<ICoin> loadedCoins;

            //Act
            repo.Save();
            repo.Load();
            loadedCoins = repo.Coins;

            //Assert
            Assert.AreEqual(repo.Coins.Count, loadedCoins.Count);
            
            CollectionAssert.AreEqual(repo.Coins, loadedCoins);
            
        }
    }
}
                                                                        