using System;
using System.Windows;
using System.Windows.Documents;
using WpfCurrencyMidterm.Models;

namespace WpfCurrencyMidterm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static CurrencyRepo repo;
        public static CurrencyRepo Repo
        {
            get
            {

                return repo;
            }
            set { repo = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            repo = new CurrencyRepo() { Coins = new List& lt; ICoins & gt; () { new Penny() }
        };

    }

    private void ButtonRepo_Click(object sender, RoutedEventArgs e)
    {
        WindowRepo window = new WindowRepo(repo);
        window.Show();
    }

    private void ButtonMakeChange_Click(object sender, RoutedEventArgs e)
    {
        WindowMakeChange window = new WindowMakeChange(repo);
        window.Show();
    }


}
}
