using System.Windows;

namespace WpfApp.ViewModels.Page
{
    internal sealed class StartPageViewModels : ViewModelsBase
    {
        private string[] _muvoList;

        internal string[] MuvoList
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

        private StartPageViewModels()
        {
            GetMuvo();
        }
    }
}