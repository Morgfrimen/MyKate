using System;
using System.Threading;

namespace WpfApp.ViewModels.Information
{
    public sealed class InformWindowViewModels : ViewModelsBase
    {
        public InformWindowViewModels(CancellationTokenSource cancellationTokenSource) =>
            CancellationTokenSource = cancellationTokenSource;

        public CancellationTokenSource CancellationTokenSource { get; }

        internal void OnExitAppEvent()
        {
            this.ExitAppEvent?.Invoke();
        }

        public event Action ExitAppEvent;
    }
}