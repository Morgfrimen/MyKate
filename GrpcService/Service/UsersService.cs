using System.Linq;
using System.Threading.Tasks;

using DbConnectionLib;
using DbConnectionLib.Models;

using Grpc.Core;

using Microsoft.EntityFrameworkCore;

using Users;

namespace GrpcService.Service
{
    public sealed class UsersService : GetUserService.GetUserServiceBase
    {
        private ContextDb ContextDb { get; }

        public UsersService(ContextDb contextDb)
        {
            ContextDb = contextDb;
        }

#region Overrides of GetUserServiceBase

        public override async Task<UserResponce> UserAutorize(
            UserRequest request, ServerCallContext context)
        {
            DbSet<Admin> collection = ContextDb.Admins;

            return Enumerable.Any(collection, admin => admin.Guid == request.Guid)
                       ? await Task.FromResult
                             (new UserResponce {Status = UserResponce.Types.StatusUser.Admin})
                       : await Task.FromResult
                             (new UserResponce {Status = UserResponce.Types.StatusUser.User});
        }

#endregion
    }
}