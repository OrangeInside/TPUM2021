using System.ComponentModel;
using Logic;
using System.Windows.Input;
using System.Windows;
using Logic.Services;
using System.Threading.Tasks;
using System;

namespace ClientPresentation.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly SrvConnect serviceConnect;

        public event PropertyChangedEventHandler PropertyChanged;

        private string connectionUri = "ws://localhost:8081/";
        public string ConnectionUri
        {
            get => connectionUri;
            set
            {
                connectionUri = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ConnectionUri"));
                //OnPropertyChanged("ConnectionUri");
            }
        }

        public ICommand AddOrderCmd { get; set; } = null;

        public ICommand ConnectCmd { get; set; } = null;

        public ICommand Clients { get; private set; }
        public ICommand Orders { get; private set; }
        public ICommand Vinyls { get; private set; }

        public MainWindowViewModel()
        {
            serviceConnect = new SrvConnect();

            Clients = new CmdLoadPage(this, "View/Clients.xaml");
            Orders = new CmdLoadPage(this, "View/Orders.xaml");
            Vinyls = new CmdLoadPage(this, "View/Vinyls.xaml");

            ConnectCmd = new CmdConnect(this);

            // Load the default page on start
            //Debug.WriteLine("Starting default page...");
            Clients.Execute(null);

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

        private string currentPage;

        public string CurrentPage
        {
            get => currentPage;
            set
            {
                currentPage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPage"));
                //OnPropertyChanged("CurrentPage");
            }
        }

        private string log = "Waiting for connection logs";

        public string Log
        {
            get => log;
            set
            {
                log = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Log"));
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

        private string connectButtonText = "Connect";
        public string ConnectButtonText
        {
            get => connectButtonText;
            set
            {
                connectButtonText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ConnectButtonText"));
            }
        }

        public void SetShowPopupInfo()
        {
            PopupText = "If something is out of stock feel free to contact us!";
            ShowPopupInfo = Visibility.Visible;
        }

        public bool IsServiceConnected()
        {
            return serviceConnect.IsConnected;
        }

        public async Task<bool> EstablishConnection(Uri peerUri)
        {
            ConnectButtonText = "Connecting...";
            bool result = await serviceConnect.Connect(peerUri, ShowLog);

            if (result)
            {
                ConnectButtonText = "Disconnect";
            }
            else
            {
                ConnectButtonText = "Connect";
            }

            return result;
        }

        public async Task Disconnect()
        {
            await serviceConnect.Disconnect();
            ConnectButtonText = "Connect";
        }

        public void ShowLog(string log)
        {
            Log = log;
        }
    }
}
