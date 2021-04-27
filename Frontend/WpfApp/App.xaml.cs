using System;
using System.Windows;

//using Test;

//using Grpc.Net.Client;

using WpfApp.View;
using WpfApp.ViewModels;

namespace WpfApp
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static string ConnectionStatus { get; set; }

        private async void App_OnStartup(object sender, StartupEventArgs e)
        {
            //try
            //{
            //    using var chanel = GrpcChannel.ForAddress("https://localhost:5001");
            //    var test = new TestConnection.TestConnectionClient(chanel);
            //    var response = await test.SayHelloAsync(new() { Name = "Тест успешен" });
            //    ConnectionStatus = response.Message;


            //}
            //catch (Exception)
            //{
            //    ConnectionStatus = "Соединение не установленно"; //TODO: Resource
            //}
            MainWindow main = new()
            {
                DataContext = new MainWindowViewModels() { ConnectionStatus = ConnectionStatus }
            };
            main.Show();
        }
    }
}