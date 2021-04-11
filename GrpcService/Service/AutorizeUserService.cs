using System.Diagnostics;
using System.Threading.Tasks;

using Autorize;

using AutorizeUserLib;

using CommonValueLib;

using Grpc.Core;

namespace GrpcServer.Service
{
    public sealed class AutorizeUserService : Autorize.Autorize.AutorizeBase
    {
#region Methods

        public override Task<ResponseAutorize> AutorizedUser(RequestAutorize request, ServerCallContext context)
        {
            Autorized autorized = new(request.Token.Role);
            bool result = Validation(autorized.GetStatusUser());
            ResponseAutorize response = new() {Result = result};

            return Task.FromResult(response);
        }

        private static bool Validation(UserToken userToken)
        {
            if (userToken is UserToken.Unknown)
            {
                Debug.Print("Не известное состояние");

                return false;
            }

            return true;
        }

#endregion
    }
}