using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using AvaloniaTestApp.Helpers;

namespace AvaloniaTestApp
{
    public class MainViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand TestCommand
        {
            get;
            private set;
        }

        private void TestCommand_Execute(object parameter)
        {
            mCallCount++;
            Message = "CallCount = " + mCallCount;
        }

        private string mMessage;
        private int mCallCount = 0;

        public MainViewModel()
        {
            TestCommand = new CommandImpl(TestCommand_Execute);
        }

        public string Message
        {
            get => mMessage;
            set
            {
                mMessage = value;
                OnPropertyChanged();
            }
        }

    }
}