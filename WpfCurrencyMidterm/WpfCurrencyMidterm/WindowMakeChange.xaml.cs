using System.Windows;
using WpfCurrencyMidterm.Models;
using WpfCurrencyMidterm.ViewModels;

namespace WpfCurrencyMidterm
{
    /// <summary>
    /// Interaction logic for WindowMakeChange.xaml
    /// </summary>
    public partial class WindowMakeChange : Window
    {
        ICurrencyRepo repo;

        public WindowMakeChange(CurrencyRepo repo)
        {
            this.repo = repo;
            InitializeComponent();
        }

        /// <summary>
        /// Sets DataContext for UserControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakeChangeView1_Loaded(object sender, RoutedEventArgs e)
        {
            this.MakeChangeView1.DataContext = new MakeChangeViewModel(repo);

        }
    }
}
