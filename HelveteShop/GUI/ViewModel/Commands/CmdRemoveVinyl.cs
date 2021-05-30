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
            //vinylsManager = ClientLogic.Logic.GetVinylsManager();
        }

        public bool CanExecute(object parameter)
        {
            return vinylsViewModel != null;// && vinylsViewModel.Title != "" && vinylsViewModel.Band != "" && vinylsViewModel.Price != "";
        }

        public void Execute(object parameter)
        {
            vinylsViewModel.SrvVinyl.RemoveVinyl(vinylsViewModel.SelectedVinyl.ID, 1);
            vinylsViewModel?.ClearUserInputs();
        }
    }
}
