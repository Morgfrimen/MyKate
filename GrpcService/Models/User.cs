using System;

namespace GrpcService
{
    internal sealed class User
    {
        public User(Guid guidUser) => GuidUser = guidUser;

        internal Guid GuidUser { get; }
    }
}