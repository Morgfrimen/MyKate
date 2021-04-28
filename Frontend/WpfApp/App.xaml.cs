using System;
using System.Windows;

using ProtoConnectionLibWPF;

using WpfApp.View;
using WpfApp.ViewModels;

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
            ConnectionServiceClient client = new();
            UserServiceClient userService = new();
            MuvoServiceClient muvo = new();
            ListMuvo = await muvo.GetMuvoList();
            MainWindow main = new()
            {
                DataContext = new MainWindowViewModels
                {
                    ConnectionStatus = await client.ConnectionCheck(),
                    UserStatus = (await userService.GetStatusUser()).ToString("G")
                }
            };
            main.Show();
        }
    }
}