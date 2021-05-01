using System;
using System.Threading;
using System.Threading.Tasks;

using Grpc.Net.Client;

using Users;

namespace ProtoConnectionLibWPF
{
    public sealed class UserServiceClient
    {
        public static async Task<UserResponce.Types.StatusUser> GetStatusUser(
            CancellationToken token)
        {
            if (token.IsCancellationRequested) return default;

            UserResponce.Types.StatusUser userStatus;

            try
            {
                GrpcChannel channel = Cache.ChannelServer;
                GetUserService.GetUserServiceClient user = new(channel);
                UserResponce response = await user.UserAutorizeAsync
                                        (
                                            new() {Guid = Cache.GuidUser.ToString()},
                                            cancellationToken: token
                                        );
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