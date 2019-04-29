using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfCurrencyMidterm.Models;
using WpfCurrencyMidterm.ViewModels;

namespace WpfCurrencyMidterm.Views
{
    /// <summary>
    /// Interaction logic for UserControlMakeChangeTest.xaml
    /// </summary>
    public partial class UserControlMakeChangeTest : UserControl
    {
        public UserControlMakeChangeTest()
        {
            InitializeComponent();
            DataContext = new MakeChangeViewModel(new CurrencyRepo());
        }
    }
}
