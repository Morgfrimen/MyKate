using System;
using System.Threading;
using System.Windows;

using ProtoConnectionLibWPF;

using Users;

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
        internal string[] ListMuvo { get; private set; }

        internal UserResponce.Types.StatusUser
            StatusUser
        {
            get;
            private set;
        } //Это нужно для выбора Footer в отчетах (пока)ничего умнее ночью в голову мне не пришло :)

#region Overrides of Application

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            ProtoConnectionLibWPF.Core.CloseChannel();
            Environment.Exit(0);
        }

#endregion

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
            ListMuvo = await MuvoServiceClient.GetMuvoList(cancellationTokenSource.Token);
            StatusUser = await UserServiceClient.GetStatusUser(cancellationTokenSource.Token);
            MainWindow main = new()
            {
                DataContext = new MainWindowViewModels
                {
                    ConnectionStatus = await client.ConnectionCheck(cancellationTokenSource.Token),
                    UserStatus = StatusUser.ToString("G")
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