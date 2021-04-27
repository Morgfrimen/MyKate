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
        private async void App_OnStartup(object sender, StartupEventArgs e)
        {
            ConnectionServiceClient client = new();
            UserServiceClient userService = new();
            MuvoServiceClient muvo = new();
            MainWindow main = new()
            {
                DataContext = new MainWindowViewModels
                {
                    ConnectionStatus = await client.ConnectionCheck(),
                    UserStatus = (await userService.GetStatusUser()).ToString("G"),
                    MuvoList = await muvo.GetMuvoList()
                }
            };
            main.Show();
        }

#region Overrides of Application

        protected override void OnExit(ExitEventArgs e)
        {
            Core.CloseChannel();
            base.OnExit(e);
        }

#endregion
    }
}