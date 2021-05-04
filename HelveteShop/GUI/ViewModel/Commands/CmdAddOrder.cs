using System;
using System.Windows.Input;
using Logic;

namespace GUI.ViewModel
{
    public class CmdAddOrder : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private OrdersViewModel ordersViewModel = null;
        private IOrdersManager ordersManager = null;

        public CmdAddOrder(OrdersViewModel ovm)
        {
            ordersViewModel = ovm;
            ordersManager = Logic.Logic.GetOrdersManager();
        }

        public bool CanExecute(object parameter)
        {
            return ordersViewModel != null && ordersViewModel.SelectedClient != null && ordersViewModel.SelectedVinyl != null && ordersViewModel.SelectedClient.Name != "" && ordersViewModel.SelectedVinyl.Title != "";
        }

        public void Execute(object parameter)
        {
            ordersManager?.AddOrder(ordersViewModel.CreateOrderDTO());
        }
    }
}
