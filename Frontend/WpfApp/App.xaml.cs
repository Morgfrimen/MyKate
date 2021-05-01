using System;
using System.Threading;
using System.Windows;

using ProtoConnectionLibWPF;

using WpfApp.View;
using WpfApp.View.InformWindow;
using WpfApp.ViewModels;
using WpfApp.ViewModels.Information;

namespace WpfApp
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
#region Overrides of Application

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            ProtoConnectionLibWPF.Core.CloseChannel();
            Environment.Exit(0);
        }

#endregion

        internal string[] ListMuvo { get; private set; }

        private async void App_OnStartup(object sender, StartupEventArgs e)
        {
            CancellationTokenSource cancellationTokenSource = new();
            InformWindowViewModels informVm = new(cancellationTokenSource);
            informVm.ExitAppEvent += InformVM_ExitAppEvent;
            InformationWindow informWindows = new()
            {
                DataContext = informVm
            };
            informWindows.Show();
            ConnectionServiceClient client = new();
            UserServiceClient userService = new();
            MuvoServiceClient muvo = new();
            ListMuvo = await muvo.GetMuvoList(cancellationTokenSource.Token);
            MainWindow main = new()
            {
                DataContext = new MainWindowViewModels
                {
                    ConnectionStatus = await client.ConnectionCheck(cancellationTokenSource.Token),
                    UserStatus = (await userService.GetStatusUser(cancellationTokenSource.Token)).ToString("G")
                }
            };
            main.Show();
            informWindows.Close();
        }

        private void InformVM_ExitAppEvent()
        {
            Shutdown(0);
        }
    }
}