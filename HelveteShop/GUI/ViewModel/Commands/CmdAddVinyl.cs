using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Logic.Managers;

namespace GUI.ViewModel
{
    public class CmdAddVinyl : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private VinylsViewModel vinylsViewModel = null;
        private VinylsManager vinylsManager = null;

        public CmdAddVinyl(VinylsViewModel vvm)
        {
            vinylsViewModel = vvm;
            vinylsManager = Logic.Logic.GetVinylsManager();
        }

        public bool CanExecute(object parameter)
        {
            return vinylsViewModel != null && vinylsViewModel.Title != "" && vinylsViewModel.Band != "" && vinylsViewModel.Price != "";
        }

        public void Execute(object parameter)
        {
            vinylsManager?.AddVinyl(vinylsViewModel.CreateVinylDTO());
            vinylsViewModel?.ClearUserInputs();
        }
    }
}
