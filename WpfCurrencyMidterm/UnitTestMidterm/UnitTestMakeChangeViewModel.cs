using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WpfCurrencyMidterm.ViewModels;
using WpfCurrencyMidterm.Models;
using System.ComponentModel;

namespace WpfCurrencyMidterm
{
    [TestClass]
    public class UnitTestMakeChangeViewModel
    {

        MakeChangeViewModel vm;

        public UnitTestMakeChangeViewModel()
        {
            vm = new MakeChangeViewModel(new CurrencyRepo());
        }

        [TestMethod]
        public void NotifyPropertyChanged_tests()
        {
            //Arrange
            List<string> receivedEvents = new List<string>();

            vm.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
            {
                receivedEvents.Add(e.PropertyName);
            };

            //Act
            vm.RepoTotal = 1;
            vm.OCoins.Add(new Penny());

            //Assert
            
            Assert.AreEqual(receivedEvents[0], "RepoTotal");
            
        }
    }
}
