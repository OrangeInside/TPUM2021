using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Logic.DTO;
using Logic.Managers;
using System.Windows.Input;

namespace GUI.ViewModel
{
    public class VinylsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RefreshVinyls() => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Vinyls"));

        private VinylsManager vinylsManager = null;
        public ICommand AddClientCmd { get; set; } = null;

        public VinylsViewModel()
        {
            vinylsManager = Logic.Logic.GetVinylsManager();

            vinylsManager.OnRefreshClients += RefreshVinyls;

           // AddClientCmd = new Commands.CmdAddClient(this);
        }

        ~VinylsViewModel()
        {
            vinylsManager.OnRefreshClients -= RefreshVinyls;
        }

        public ObservableCollection<VinylDTO> Vinyls => new ObservableCollection<VinylDTO>(vinylsManager?.GetAllVinylsAsDTO());

    }

}
