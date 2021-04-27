using System.Threading.Tasks;

using Grpc.Core;

using Test;

namespace GrpcService.Service
{
    public sealed class TestConnectionService : Test.TestConnection.TestConnectionBase
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