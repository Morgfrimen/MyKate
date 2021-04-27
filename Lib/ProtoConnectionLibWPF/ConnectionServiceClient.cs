using System;
using System.Threading.Tasks;

using Connection;

using Grpc.Net.Client;

using ProtoConnectionLibWPF.Enums;

//В проекте WPF gRPC отлетает, на сайте майков указано это, поэтому нужно делать через либу
namespace ProtoConnectionLibWPF
{
    public sealed class ConnectionServiceClient
    {
        private string _connectionStatus;

        public async Task<string> ConnectionCheck()
        {
            try
            {
                using GrpcChannel chanel = GrpcChannel.ForAddress("https://localhost:5001");
                TestConnection.TestConnectionClient test = new(chanel);
                HellResponce response = await test.SayHelloAsync(new());
                _connectionStatus = response.Status
                                        ? nameof(ConnectionStatusEnum.OK)
                                        : nameof(ConnectionStatusEnum.ERROR);
            }
            catch (Exception)
            {
                _connectionStatus = nameof(ConnectionStatusEnum.ERROR); //TODO: Resource
            }

            return _connectionStatus;
        }
    }
}