namespace WpfApp.ViewModels
{
    public sealed class MainWindowViewModels : ViewModelsBase
    {
        private readonly string _connectionStatus = "Default";

        public string UserStatus { get; init; }

        public string ConnectionStatus
        {
            get => _connectionStatus;
            init
            {
                _connectionStatus = value;
                OnPropertyChanged(nameof(ConnectionStatus));
            }
        }
    }
}