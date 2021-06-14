using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp.ViewModels
{
    public abstract class ViewModelsBase : INotifyPropertyChanged
    {
#region Implemented

        [NotifyPropertyChangedInvocator]
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new(propertyName));
        }

#endregion

        public event PropertyChangedEventHandler PropertyChanged;
    }
}