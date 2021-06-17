using System;

namespace GrpcService.Models
{
    internal sealed class User
    {
        internal Guid GuidUser { get; }

        public User(Guid guidUser) => GuidUser = guidUser;
    }
}