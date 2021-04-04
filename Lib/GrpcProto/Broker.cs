using System.Threading.Tasks;

using Autorize;

using Grpc.Net.Client;

namespace GrpcProtoClient
{
    public sealed class Broker
    {
#region Fields

        private Autorize.Autorize.AutorizeClient _autorizedClient;

#endregion

#region Constructors

        private Broker(GrpcChannel channel) => Channel = channel;

#endregion

#region Properties

        private GrpcChannel Channel { get; }
        public static Broker Instanse { get; private set; }

#endregion

#region Methods

        public async Task<ResponseAutorize> AutorizedAsync(RequestAutorize request)
        {
            _autorizedClient ??= new Autorize.Autorize.AutorizeClient(Channel);

            return await _autorizedClient.AutorizedUserAsync(request, default);
        }

        public static Broker GetBroker(GrpcChannel channel) => Instanse ??= new Broker(channel);

#endregion
    }
}