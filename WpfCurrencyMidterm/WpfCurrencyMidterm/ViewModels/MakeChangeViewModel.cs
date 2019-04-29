using WpfCurrencyMidterm.Models;

namespace WpfCurrencyMidterm.ViewModels
{
    public class MakeChangeViewModel : BaseViewModel
    {
        private ICurrencyRepo repo;
        private double amount = 0;
        public BasicCommand basicCommand { get; private set; }
        private SaveableCurrencyRepo saveRepo;
        private ObservableCollection<ICoin> vmCoins = new ObservableCollection<ICoin>();


        public MakeChangeViewModel(ICurrencyRepo repo)
        {
            this.repo = repo;
        }

        public ObservableCollection<ICoin> VMCoins
        {
            get { return vmCoins; }
            set { vmCoins = value; RaisedPropertyChanged("VMCoins"); }
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
            saveRepo = new SaveableCurrencyRepo(this.repo.Coins);
            this.saveRepo.Save();
        }

        public BasicCommand Ocoin
        {
            get
            {
                if (basicCommand == null)
                {
                    basicCommand = new BasicCommand(OCoin);
                }
                return basicCommand;
            }
        }

        private void OCoin()
        {
            this.repo = this.repo.MakeChange(Amount);
            for (int i = 0; i < this.repo.GetCoinCount(); i++)
            {
                vmCoins.Add(this.repo.Coins[i]);
            }
        }

        //This will represent the value the user input into the textbox
        public double Amount
        {
            get
            {
                return this.amount;
            }
            set
            {
                RaisedPropertyChanged("Amount");
                this.amount = value;
            }
        }
    }
}
