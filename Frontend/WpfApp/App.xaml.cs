using System.Windows;

using CommonValueLib;

using Grpc.Net.Client;

using GrpcProtoClient;

namespace WpfApp
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
#region Fields

        private GrpcChannel channel;

#endregion

#region Properties

        internal Autorize.Autorize.AutorizeClient AutorizeUser { get; private set; }
        internal UserToken UserToken { get; private set; }

#endregion

#region Methods

        protected override void OnExit(ExitEventArgs e)
        {
            channel.Dispose();
            base.OnExit(e);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            channel = GrpcChannel.ForAddress(@"https://localhost:5001");
            _ = Broker.GetBroker(channel);
            UserToken = UserToken.Admin;
        }

#endregion
    }
}