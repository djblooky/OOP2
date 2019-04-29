using System;
using System.Windows.Input;

namespace WpfCurrencyMidterm.ViewModels
{
    public class BasicCommand : ICommand
    {
        private Action commandAction;

        public event EventHandler CanExecuteChanged = (sender, e) => { };

        public BasicCommand(Action action)
        {
            commandAction = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            commandAction();
        }
    }
}
