using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ClientPresentation.ViewModel
{
    class CmdLoadPage : ICommand
    {
        private readonly MainWindowViewModel mainWindowViewModel;
        private readonly string uri;

        public CmdLoadPage(MainWindowViewModel mainWindowViewModel, string uri)
        {
            this.mainWindowViewModel = mainWindowViewModel;
            this.uri = uri;
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter)
        {
            return mainWindowViewModel.IsServiceConnected();
        }

        public void Execute(object parameter)
        {
            mainWindowViewModel.CurrentPage = uri;
        }
    }
}
