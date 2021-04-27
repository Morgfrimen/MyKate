using System;
using System.Windows;

using Test;

using Grpc.Net.Client;

namespace WpfApp
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
#region Overrides of Application

        protected override async void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            try
            {
                using var chanel = GrpcChannel.ForAddress("https://localhost:5001");
                var test = new TestConnection.TestConnectionClient(chanel);
                var response = await test.SayHelloAsync(new HelloRequest() { Name = "Тест успешен" });
                MessageBox.Show($"Ответ от сервера:{response.Message}");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ответ от сервера:{exception.Message}");
            }
        }

#endregion
    }
}