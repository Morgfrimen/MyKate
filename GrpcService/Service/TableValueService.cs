using System.Threading.Tasks;

using Grpc.Core;

using Table;

namespace GrpcProtoClient.Service
{
    public sealed class TableValueService : Table.TableService.TableServiceBase
    {
#region Overrides of TableServiceBase

        public override Task<TableResponse> ChangeTableValue(TableRequest request, ServerCallContext context)
        {
            //TODO: model
            return base.ChangeTableValue(request, context);
        }

#endregion
    }
}