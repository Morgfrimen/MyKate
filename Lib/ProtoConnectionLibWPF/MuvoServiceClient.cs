using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Grpc.Net.Client;

using Muvo;

namespace ProtoConnectionLibWPF
{
    public sealed class MuvoServiceClient
    {
        public async Task<string[]> GetMuvoList(CancellationToken token)
        {
            if (token.IsCancellationRequested)
                return null;

            try
            {
                GrpcChannel channel = Cache.ChannelServer;
                GetListMuvoService.GetListMuvoServiceClient client = new(channel);
                MuvoListResponce responce = await client.MuvoListAsync(new(),cancellationToken: token);

                return responce.Arrays.Select(responceArray => responceArray.NameMuvo).ToArray();
            }
            catch (System.Exception)
            {
                //TODO:LKogger
                return null;
            }
        }
    }
}