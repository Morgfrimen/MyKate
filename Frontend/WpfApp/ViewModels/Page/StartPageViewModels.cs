using System.Windows;

namespace WpfApp.ViewModels.Page
{
    public sealed class StartPageViewModels : ViewModelsBase
    {
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

        private void GetMuvo()
        {
            MuvoList = (Application.Current as App).ListMuvo;
        }

        internal StartPageViewModels()
        {
            GetMuvo();
        }
    }
}