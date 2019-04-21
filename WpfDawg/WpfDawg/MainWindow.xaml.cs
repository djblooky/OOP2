using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfDawg.Models;

namespace WpfDawg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dawg d;

        public MainWindow()
        {
            InitializeComponent();
            d = new Dawg();
        }

        public void BindDawgToUI()
        {
            txtName.Text = d.Name;
            txtCost.Text = d.Cost.ToString();
            txtVegan.Text = d.IsVegan.ToString();
        }


    }
}
