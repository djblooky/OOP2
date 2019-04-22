using System.Windows;
using WpfDawg.Models;
using WpfDawg.ViewModels;

namespace WpfDawg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModelDawg vmDawg;
        Dawg d;

        public MainWindow()
        {
            InitializeComponent();        
            d = new Dawg();
            vmDawg = new ViewModelDawg(d);
            //BindDawgToUI();
            //DataContext = vmDawg;
        }

        /*
        public void BindDawgToUI()
        {
            txtName.Text = d.Name;
            txtCost.Text = d.Cost.ToString();
            txtVegan.Text = d.IsVegan.ToString();
        } */

        public void UserControlDawg1_Loaded(object sender, RoutedEventArgs e) 
        {
            UserControlDawg1.DataContext = vmDawg;
        }
    }
}
