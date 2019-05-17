using System.Collections.ObjectModel;
using WpfCurrencyMidterm.Models;

namespace WpfCurrencyMidterm.ViewModels
{
    public class MakeChangeViewModel : BaseViewModel
    {
        private ICurrencyRepo repo;
        private double amount;
        public BasicCommand BasicCmd { get; private set; }
        private SaveableCurrencyRepo saveRepo;
        public ObservableCollection<ICoin> OCoins;
        public int RepoTotal;


        public MakeChangeViewModel(ICurrencyRepo repo)
        {
            this.repo = repo;
            RepoTotal = 0;
            amount = 0;
            OCoins = new ObservableCollection<ICoin>();
        }

        public ObservableCollection<ICoin> VMCoins
        {
            get { return OCoins; }
            set { OCoins = value; RaisePropertyChangedEvent("VMCoins"); }
        }

        public BasicCommand SaveCoin
        {
            get
            {
                BasicCmd = new BasicCommand(saveCoin);
                return BasicCmd;
            }
        }

        public void saveCoin()
        {
            saveRepo = new SaveableCurrencyRepo(repo.Coins);
            saveRepo.Save();
        }

        public BasicCommand Ocoin
        {
            get
            {
                if (BasicCmd == null)
                {
                    BasicCmd = new BasicCommand(OCoin);
                }
                return BasicCmd;
            }
        }

        private void OCoin()
        {
            repo = repo.CreateChange(Amount);
            for (int i = 0; i < repo.GetCoinCount(); i++)
            {
                OCoins.Add(repo.Coins[i]);
            }
        }

        public double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                RaisePropertyChangedEvent("Amount");
                amount = value;
            }
        }
    }
}
