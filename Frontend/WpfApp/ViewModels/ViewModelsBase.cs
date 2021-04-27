using System.ComponentModel;
using System.Runtime.CompilerServices;

using WpfApp.Annotations;

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