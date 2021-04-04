using Grpc.Net.Client;

using System.Windows;

using GrpcProtoClient.Service;

namespace WpfApp
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
        internal HelloService Client { get; private set; }

#region Overrides of Application

		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);
			using GrpcChannel channel = GrpcChannel.ForAddress(@"https://localhost:5001");
			Client = new HelloService();
		}

		#endregion
	}
}
