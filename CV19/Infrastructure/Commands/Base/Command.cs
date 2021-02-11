using System;
using System.Windows.Input;

namespace CV19.Infrastructure.Commands.Base
{
   internal abstract class Command : ICommand
    {
        public event EventHandler CanExecuteChanged {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter);

        public void Execute(object parameter);
    }
}
