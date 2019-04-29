using System.Windows;
using WpfCurrencyMidterm.Models;
using WpfCurrencyMidterm.ViewModels;

namespace WpfCurrencyMidterm
{
    /// <summary>
    /// Interaction logic for WindowRepo.xaml
    /// </summary>
    public partial class WindowRepo : Window
    {
        public WindowRepo(CurrencyRepo repo)
        {
            InitializeComponent();
            CurrencyRepoViewModel repoVM = new CurrencyRepoViewModel(repo);
            UserControlRepo1.DataContext = repoVM;
        }

        private void UserControlRepo1_Loaded(object sender, RoutedEventArgs e)
        {
            UserControlRepo1.cbCoinName.SelectedIndex = 0; //Select the first real item not null
        }
    }
}
