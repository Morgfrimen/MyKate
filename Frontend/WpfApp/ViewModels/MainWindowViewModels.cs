namespace WpfApp.ViewModels
{
    public sealed class MainWindowViewModels : ViewModelsBase
    {
        private readonly string _connectionStatus = "Default";

        public string ConnectionStatus
        {
            get => _connectionStatus;
            init
            {
                _connectionStatus = value;
                OnPropertyChanged(nameof(ConnectionStatus));
            }
        }

        private readonly string _userStatus;

        public string UserStatus
        {
            get => _userStatus;
            init => _userStatus = value;
        }
    }
}