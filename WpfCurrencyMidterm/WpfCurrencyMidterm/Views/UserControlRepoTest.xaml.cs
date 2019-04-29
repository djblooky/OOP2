using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfCurrencyMidterm.Models;
using WpfCurrencyMidterm.ViewModels;

namespace WpfCurrencyMidterm.Views
{
    /// <summary>
    /// Interaction logic for UserControlRepoTest.xaml
    /// </summary>
    public partial class UserControlRepoTest : UserControl
    {
        public UserControlRepoTest()
        {
            InitializeComponent();
            DataContext = new CurrencyRepoViewModel(new CurrencyRepo());
        }
    }
}
