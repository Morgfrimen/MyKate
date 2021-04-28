using ProtoConnectionLibWPF;

namespace WpfApp.ViewModels
{
    public sealed class StartPageViewModels : ViewModelsBase
    {
        public StartPageViewModels()
        {
            GetMuvo();
        }

        private void GetMuvo()
        {
            MuvoList = (App.Current as App).ListMuvo;
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