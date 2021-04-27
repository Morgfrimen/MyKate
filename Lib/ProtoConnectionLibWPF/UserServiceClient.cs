using System;
using System.Threading.Tasks;

using Grpc.Net.Client;

using Users;

namespace ProtoConnectionLibWPF
{
    public sealed class UserServiceClient
    {
        public async Task<UserResponce.Types.StatusUser> GetStatusUser()
        {
            UserResponce.Types.StatusUser userStatus = default;
            try
            {
                GrpcChannel channel = Cache.ChannelServer;
                GetUserService.GetUserServiceClient user = new(channel);
                UserResponce response = await user.UserAutorizeAsync(new(){Guid = Cache.GuidUser.ToString()});
                userStatus = response.Status;
            }
            catch (Exception)
            {
                userStatus = UserResponce.Types.StatusUser.User; //TODO: Resource
            }

            return userStatus;
        }
    }
}
