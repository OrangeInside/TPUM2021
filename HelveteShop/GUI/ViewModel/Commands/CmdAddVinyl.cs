using System;
using System.Windows.Input;
using ClientLogic;

namespace ClientPresentation.ViewModel
{
    public class CmdAddVinyl : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private VinylsViewModel vinylsViewModel = null;
        private IVinylService vinylsManager = null;

        public CmdAddVinyl(VinylsViewModel vvm)
        {
            vinylsViewModel = vvm;
            //vinylsManager = ClientLogic.Logic.GetVinylsManager();
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
