using System;
using System.Windows.Input;

namespace AvaloniaTestApp.Helpers
{
    public class CommandImpl: ICommand
    {
        private readonly Action<object> mExecute;

        public CommandImpl(Action<object> execute)
        {
            mExecute = execute ?? throw new ArgumentNullException(nameof(execute));
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mExecute(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}