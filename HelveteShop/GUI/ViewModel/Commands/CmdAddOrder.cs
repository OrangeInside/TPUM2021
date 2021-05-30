using System;
using System.Windows.Input;
using ClientLogic;

namespace ClientPresentation.ViewModel
{
    public class CmdAddOrder : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private OrdersViewModel ordersViewModel = null;
        private IOrderService ordersManager = null;

        public CmdAddOrder(OrdersViewModel ovm)
        {
            ordersViewModel = ovm;
        }

        public bool CanExecute(object parameter)
        {
            return ordersViewModel != null && ordersViewModel.SelectedClient != null && ordersViewModel.SelectedVinyl != null && ordersViewModel.SelectedClient.Name != "" && ordersViewModel.SelectedVinyl.Title != "";
        }

        public void Execute(object parameter)
        {

        }
    }
}
