﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Logic.Managers;
using Logic;

namespace GUI.ViewModel.Commands
{
    public class CmdAddClient : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private ClientsViewModel clientsViewModel = null;
        private ClientsManager clientsManager = null;

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