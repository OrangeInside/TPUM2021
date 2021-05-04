using System.ComponentModel;
using Logic;
using System.Windows.Input;
using System.Windows;

namespace GUI.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand AddOrderCmd { get; set; } = null;

        public MainWindowViewModel()
        {
            PopupText = "";
            ShowPopupInfo = Visibility.Hidden;

            Timer popupTimer = new Timer(10000);
            popupTimer.OnTimerReach += SetShowPopupInfo;
        }

        private Visibility showPopupInfo = Visibility.Hidden;

        public Visibility ShowPopupInfo
        {
            get => showPopupInfo;

            set
            {
                showPopupInfo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ShowPopupInfo"));
            }
        }

        private string popupText = "";

        public string PopupText
        {
            get => popupText;

            set
            {
                popupText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PopupText"));
            }
        }


        public void SetShowPopupInfo()
        {
            PopupText = "If something is out of stock feel free to contact us!";
            ShowPopupInfo = Visibility.Visible;
        }
    }
}
