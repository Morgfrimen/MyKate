using System.Windows;

namespace WpfApp.ViewModels.Page
{
    public sealed class StartPageViewModels : ViewModelsBase
    {
        private string[] _muvoList;

        public StartPageViewModels()
        {
            GetMuvo();
        }

        private void GetMuvo()
        {
            MuvoList = (Application.Current as App).ListMuvo;
        }

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