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
            MainWindow main = new()
            {
                DataContext = new MainWindowViewModels
                    {ConnectionStatus = await client.ConnectionCheck()}
            };
            main.Show();
        }
    }
}