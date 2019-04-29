using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;
using WpfCurrencyMidterm.ViewModels;
using WpfCurrencyMidterm.Models;

namespace WpfCurrencyMidterm
{
    [TestClass]
    public class UnitTestCurrencyRepoViewModel
    {

        ICurrencyRepo repo;
        CurrencyRepoViewModel vm;

        public UnitTestCurrencyRepoViewModel()
        {

        }

        [TestMethod]
        public void Coins_For_ComboBoxCoins_Collections_AreSame() 
        {
            //Arrange
            repo = new CurrencyRepo();
            vm = new CurrencyRepoViewModel(repo);

            ObservableCollection<ICoin> testCoinsforcdCoins;

            //Act
            testCoinsforcdCoins = vm.CoinsForcdCoins;
            //Assert
            CollectionAssert.AreEqual(((CurrencyRepo)repo).Coins, testCoinsforcdCoins);

        }

    }
}
