using System.Collections.Generic;
using System.Collections.ObjectModel;
using WpfCurrencyMidterm.Models;

namespace WpfCurrencyMidterm.ViewModels
{
    public class CurrencyRepoViewModel : BaseViewModel
    {
        private ICurrencyRepo repo;
        private SaveableCurrencyRepo saveRepo;
        private ICoin coinName;
        private int coinNum;
        public ICoin CoinName
        {
            get { return coinName; }
            set
            {
                coinName = value;
                RaisePropertyChangedEvent("CoinName");
            }
        }

        private ObservableCollection<ICoin> coinsForcdCoins;

        public ObservableCollection<ICoin> CoinsForcdCoins
        {
            get { return coinsForcdCoins; }
            set { coinsForcdCoins = value; RaisePropertyChangedEvent("CoinsForcdCoins"); }
        }

        public BasicCommand basicCommand { get; private set; }

        public CurrencyRepoViewModel(ICurrencyRepo repo)
        {
            this.repo = repo;
            CoinsForcdCoins = new ObservableCollection<ICoin>(this.repo.Coins);
        }

        public BasicCommand NewRepo
        {
            get
            {
                basicCommand = new BasicCommand(newRepo);
                return basicCommand;
            }
        }

        public void newRepo()
        {
            repo.Coins = new List<ICoin>
            {
                new Penny(),
                new Dime(),
                new Quarter(),
                new Nickel(),
                new HalfDollarCoin()
            };
            RaisePropertyChangedEvent("RepoTotal");
        }


        public BasicCommand SaveCoin
        {
            get
            {
                basicCommand = new BasicCommand(saveCoin);
                return basicCommand;
            }
        }

        public void saveCoin()
        {
            saveRepo = new SaveableCurrencyRepo(repo.Coins);
            saveRepo.Save();
        }

        public BasicCommand LoadCoin
        {
            get
            {
                basicCommand = new BasicCommand(loadCoin);
                return basicCommand;
            }
        }

        public void loadCoin()
        {
            saveRepo = new SaveableCurrencyRepo(repo.Coins);
            repo.Coins = saveRepo.Load();
            RaisePropertyChangedEvent("RepoTotal");

        }

        public BasicCommand AddCoinCommand
        {
            get
            {
                basicCommand = new BasicCommand(addCoin);
                return basicCommand;
            }
        }

        public void addCoin()
        {
            for (int i = 0; i < CoinNum; i++)
            {
                repo.AddCoin(CoinName);
            }
            RaisePropertyChangedEvent("RepoTotal");
        }

        public double RepoTotal
        {
            get { return repo.TotalValue(); }
        }

        public int CoinNum
        {
            get
            {
                return coinNum;
            }

            set
            {
                RaisePropertyChangedEvent("CoinNum");
                coinNum = value;
            }
        }

    }
}
