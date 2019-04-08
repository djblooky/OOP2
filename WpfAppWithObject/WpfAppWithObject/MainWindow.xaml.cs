using System.Windows;

namespace WpfAppWithObject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Dawg_Button_Click(object sender, RoutedEventArgs e)
        {
            WpfDawg dawgWin = new WpfDawg();
            dawgWin.Show();
        }
        private void Food_Button_Click(object sender, RoutedEventArgs e)
        {
            WpfFood foodWin = new WpfFood();
            foodWin.Show();
        }

    }
}
