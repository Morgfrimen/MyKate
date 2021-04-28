using ProtoConnectionLibWPF;

namespace WpfApp.ViewModels
{
    public sealed class StartPageViewModels : ViewModelsBase
    {
        public StartPageViewModels()
        {
            GetMuvo();
        }

        private async void GetMuvo()
        {
            MuvoServiceClient muvo = new();
            MuvoList = await muvo.GetMuvoList();
        }

        private string[] _muvoList;

        public string[] MuvoList
        {
            get => _muvoList;
            private set
            {
                _muvoList = value;
                OnPropertyChanged(nameof(MuvoList));
            }
        }
    }
}