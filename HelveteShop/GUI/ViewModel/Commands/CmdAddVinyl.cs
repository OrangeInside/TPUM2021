using System;
using System.Windows.Input;
using Logic;

namespace ClientPresentation.ViewModel
{
    public class CmdAddVinyl : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private VinylsViewModel vinylsViewModel = null;
        private IVinylsManager vinylsManager = null;

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
