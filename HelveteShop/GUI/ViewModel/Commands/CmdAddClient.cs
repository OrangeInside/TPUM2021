using System;
using System.Windows.Input;
using Logic;

namespace GUI.ViewModel
{
    public class CmdAddClient : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private ClientsViewModel clientsViewModel = null;
        private IClientsManager clientsManager = null;

        public CmdAddClient(ClientsViewModel cvm)
        {
            clientsViewModel = cvm;
            clientsManager = Logic.Logic.GetClientsManager();
        }

        public bool CanExecute(object parameter)
        {
            return clientsViewModel != null && clientsViewModel.Name != "" && clientsViewModel.Address != "";
        }

        public void Execute(object parameter)
        {
            clientsManager?.AddClient(clientsViewModel.CreateClientDTO());
            clientsViewModel?.ClearUserInputs();
        }
    }
}
