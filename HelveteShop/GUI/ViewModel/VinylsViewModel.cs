using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using ClientLogic;
using System.Windows.Input;

namespace ClientPresentation.ViewModel
{
    public class VinylsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RefreshVinyls() => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Vinyls"));

        private IVinylService vinylsManager = null;
        public ICommand AddVinylCmd { get; set; } = null;

        public VinylsViewModel()
        {
            //vinylsManager = ClientLogic.Logic.GetVinylsManager();

            vinylsManager.OnRefreshVinyls += RefreshVinyls;

            AddVinylCmd = new CmdAddVinyl(this);
        }

        ~VinylsViewModel()
        {
            vinylsManager.OnRefreshVinyls -= RefreshVinyls;
        }

        //public ObservableCollection<VinylDTO> Vinyls => new ObservableCollection<VinylDTO>(vinylsManager?.GetAllVinylsAsDTO());

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

        #endregion

    }

}
