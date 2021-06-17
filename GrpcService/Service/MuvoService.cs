using System.Linq;
using System.Threading.Tasks;

using DbConnectionLib;

using Grpc.Core;

using Muvo;

namespace GrpcService.Service
{
    public sealed class MuvoService : GetListMuvoService.GetListMuvoServiceBase
    {
        private readonly ContextDb _contextDb;

#region Overrides of GetListMuvoServiceBase

        public override Task<MuvoListResponce> MuvoList(MuvoListRequest request,
                                                        ServerCallContext context)
        {
            DbConnectionLib.Models.Muvo[] listMuvo = _contextDb.Muvos.ToArray();
            MuvoListResponce.Types.array[] arrays =
                new MuvoListResponce.Types.array[listMuvo.Length];
            for (int index = 0; index < listMuvo.Length; index++)
                arrays[index] = new() {NameMuvo = listMuvo[index].Name};
            MuvoListResponce responces = new() {Arrays = {arrays}};

            return Task.FromResult(responces);
        }

#endregion

        public MuvoService(ContextDb contextDb)
        {
            _contextDb = contextDb;
            _contextDb.DefaultDbSetMuvo();
        }
    }
}