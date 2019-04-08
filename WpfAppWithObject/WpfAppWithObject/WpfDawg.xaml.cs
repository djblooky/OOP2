using System.Windows;
using System;
using WpfAppWithObject.Models;
using WpfAppWithObject.ViewModels;

namespace WpfAppWithObject
{
    /// <summary>
    /// Interaction logic for WpfDawg.xaml
    /// </summary>
    public partial class WpfDawg : Window
    {
        public WpfDawg()
        {
            InitializeComponent();
        }
    }

    private void FoodViewControl_Loaded(object sender, RoutedEventArgs e)
    {
        ViewModelFood viewControl = new WpfAppWithObject.ViewModels.ViewModelFood();
        viewControl.LoadFood();

        this.DataContext = viewControl.Food[0];
        FoodView1.DataContext = viewControl.Food[0];
    }
}
