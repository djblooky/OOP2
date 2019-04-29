using System.ComponentModel;
using System.Windows;

namespace WpfCurrencyMidterm.ViewModels
{
    public abstract class BaseViewModel : DependencyObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        protected virtual void RaisePropertyChangedEvent(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
