using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Diagnostics;

namespace ClientPresentation.ViewModel
{
    public class CmdConnect : ICommand
    {
        private readonly MainWindowViewModel mainWindowViewModel;

        public CmdConnect(MainWindowViewModel mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return mainWindowViewModel.ConnectionUri != "";
        }

        public async void Execute(object parameter)
        {
            Debug.WriteLine($"Trying to connect: {mainWindowViewModel.ConnectionUri}");

            try
            {
                if (mainWindowViewModel.IsServiceConnected())
                {
                    await mainWindowViewModel.Disconnect();
                }
                else
                {
                    bool connection = await mainWindowViewModel.EstablishConnection(new Uri(mainWindowViewModel.ConnectionUri));
                    Debug.WriteLine($"Con Result: {(connection ? "Connected" : "Failed")}");
                }
            }
            catch (UriFormatException e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
