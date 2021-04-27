using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Grpc.Net.Client;

using Muvo;

namespace ProtoConnectionLibWPF
{
    public sealed class MuvoServiceClient
    {
        public async Task<string[]> GetMuvoList()
        {
            try
            {
                GrpcChannel channel = Cache.ChannelServer;
                GetListMuvoService.GetListMuvoServiceClient client = new(channel);
                MuvoListResponce responce = await client.MuvoListAsync(new());

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