﻿using System;
using System.Threading;
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

        public async Task<string> ConnectionCheck(CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested) return default;

            try
            {
                GrpcChannel chanel = Cache.ChannelServer;
                TestConnection.TestConnectionClient test = new(chanel);
                HellResponce response = await test.SayHelloAsync
                                            (new(), cancellationToken: cancellationToken);
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