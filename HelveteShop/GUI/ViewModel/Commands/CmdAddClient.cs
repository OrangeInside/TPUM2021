using System;
using System.Windows.Input;
using ClientLogic;

namespace ClientPresentation.ViewModel
{
    public class CmdAddClient : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private ClientsViewModel clientsViewModel = null;
        private IClientService clientsManager = null;

        public CmdAddClient(ClientsViewModel cvm)
        {
            clientsViewModel = cvm;
            //clientsManager = ClientLogic.Logic.GetClientsManager();
        }

        public bool CanExecute(object parameter)
        {
            return clientsViewModel != null && clientsViewModel.Name != "" && clientsViewModel.Address != "";
        }

        public void Execute(object parameter)
        {
            //clientsManager?.AddClient(clientsViewModel.CreateClientDTO());
            clientsViewModel?.ClearUserInputs();
        }
    }
}
