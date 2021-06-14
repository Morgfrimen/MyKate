using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp.ViewModels
{
    public abstract class ViewModelsBase : INotifyPropertyChanged
    {
        [NotifyPropertyChangedInvocator]
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}