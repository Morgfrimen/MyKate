using System.ComponentModel;
using System.Runtime.CompilerServices;

using WpfApp.Annotations;

namespace WpfApp.ViewModels
{
    public abstract class ViewModelsBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}