using System.Threading.Tasks;

using Connection;

using Grpc.Core;

namespace GrpcService.Service
{
    public sealed class TestConnectionService : Connection.TestConnection.TestConnectionBase
    {
#region Overrides of TestConnectionBase

        public override Task<HellResponce> SayHello(HelloRequest request, ServerCallContext context)
        {
            var response = new HellResponce() {Message = "Соеденение есть"};

            return Task.FromResult(response);
        }

#endregion
    }
}