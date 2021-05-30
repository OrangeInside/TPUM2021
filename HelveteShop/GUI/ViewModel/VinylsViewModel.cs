using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using ClientLogic;
using System.Windows.Input;

namespace ClientPresentation.ViewModel
{
    public class VinylsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<VinylDTO> vinyls;
        private readonly IVinylService srvVinyl;

        public event PropertyChangedEventHandler PropertyChanged;
        private void RefreshVinyls() => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Vinyls"));

        private IVinylService vinylsManager = null;
        public ICommand AddVinylCmd { get; set; } = null;

        public VinylsViewModel()
        {
            //vinylsManager = ClientLogic.Logic.GetVinylsManager();

            //vinylsManager.OnRefreshVinyls += RefreshVinyls;

            //AddVinylCmd = new CmdAddVinyl(this);

            srvVinyl = ServiceFactory.CreateVinylService;
            //srvVinyl.DeviceChange += UpdateDevices;
            vinyls = new ObservableCollection<VinylDTO>();

            MainWindowViewModel.OnConnectionEstablished += RequestVinyls;
            MainWindowViewModel.OnConnectionLost += CleanVinyls;

            /*NewDeviceCommand = new NewDeviceCommand(this);
            ToggleDeviceCommand = new ToggleDeviceCommand(this);
            SaveDeviceCommand = new AddDeviceCommand(this);
            EditDeviceCommand = new EditDeviceCommand(this);
            DeleteDeviceCommand = new MessageBoxCommand(new DeleteDeviceCommand(this), null, "Do you really want to delete this device?");*/
        }

        ~VinylsViewModel()
        {
            vinylsManager.OnRefreshVinyls -= RefreshVinyls;
        }

        private async void RequestVinyls()
        {
            await srvVinyl.RefreshVinyls();
        }

        private void CleanVinyls()
        {
            Vinyls.Clear();
        }

        #region Vinyl Management

        private string title;
        private string band;
        private string price;

        public string Title
        {
            get => title;

            set
            {
                title = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Title"));
            }
        }

        public string Band
        {
            get => band;

            set
            {
                band = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Band"));
            }
        }

        public string Price
        {
            get => price;

            set
            {
                price = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        public void ClearUserInputs()
        {
            Title = "";
            Band = "";
            Price = "";
        }

        public VinylDTO CreateVinylDTO()
        {
            return new VinylDTO
            {
                Title = this.Title,
                Band = this.Band,
                Price = Decimal.Parse(this.Price)
            };
        }

        public ObservableCollection<VinylDTO> Vinyls
        {
            get => vinyls;
            set
            {
                vinyls = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Vinyls"));
            }
        }

        public void UpdateDevices()
        {
            vinyls = new ObservableCollection<VinylDTO>(srvVinyl.GetVinyls());
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Vinyls"));
        }

        #endregion

    }

}
