using System;
using System.Windows.Input;
using ClientLogic;

namespace ClientPresentation.ViewModel
{
    public class CmdRemoveVinyl : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private VinylsViewModel vinylsViewModel = null;
        private IVinylService vinylsManager = null;

        public CmdRemoveVinyl(VinylsViewModel vvm)
        {
            vinylsViewModel = vvm;
        }

        public bool CanExecute(object parameter)
        {
            return vinylsViewModel != null;
        }

        public void Execute(object parameter)
        {
            if (vinylsViewModel.SelectedVinyl != null)
            {
                vinylsViewModel.SrvVinyl.RemoveVinyl(vinylsViewModel.SelectedVinyl.ID, 1);
                vinylsViewModel?.ClearUserInputs();
            }
        }
    }
}
