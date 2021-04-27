using System.Threading.Tasks;

using Connection;

using Grpc.Core;

namespace GrpcService.Service
{
    public sealed class TestConnectionService : TestConnection.TestConnectionBase
    {
#region Overrides of TestConnectionBase

        public override Task<HellResponce> SayHello(HelloRequest request, ServerCallContext context)
        {
            HellResponce response = new() {Status = true};

            return Task.FromResult(response);
        }

#endregion
    }
}