using System;

namespace GrpcService.Models
{
    internal sealed class User
    {
        public User(Guid guidUser) => GuidUser = guidUser;

        internal Guid GuidUser { get; }
    }
}