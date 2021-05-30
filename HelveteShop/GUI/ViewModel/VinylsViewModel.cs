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
        private VinylDTO selectedVinyl;

        public event PropertyChangedEventHandler PropertyChanged;
        private void RefreshVinyls() => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Vinyls"));

        private IVinylService vinylsManager = null;
        public ICommand AddVinylCmd { get; set; } = null;
        public ICommand RemoveVinylCmd { get; set; } = null;

        public VinylsViewModel()
        {
            RemoveVinylCmd = new CmdRemoveVinyl(this);

            srvVinyl = ServiceFactory.CreateVinylService;
            srvVinyl.OnRefreshVinyls += UpdateVinyls;
            vinyls = new ObservableCollection<VinylDTO>();

            MainWindowViewModel.OnConnectionEstablished += RequestVinyls;
            MainWindowViewModel.OnConnectionLost += CleanVinyls;
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

        public IVinylService SrvVinyl
        {
            get
            {
                return (IVinylService)srvVinyl;
            }
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

        public void UpdateVinyls()
        {
            vinyls = new ObservableCollection<VinylDTO>(srvVinyl.GetVinyls());
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Vinyls"));
        }

        public VinylDTO SelectedVinyl
        {
            get => selectedVinyl;
            set
            {
                selectedVinyl = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedVinyl"));
            }
        }

        #endregion

    }

}
