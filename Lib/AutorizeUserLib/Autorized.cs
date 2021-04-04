using System;

using CommonValueLib;

namespace AutorizeUserLib
{
    public sealed class Autorized
    {
#region Fields

        private readonly UserToken _userToken;

#endregion

#region Constructors

        public Autorized(int statusUser)
        {
            if (Enum.TryParse(typeof(UserToken), statusUser.ToString(), true, out object value) && value is UserToken token)
                _userToken = token;

            //TODO: Logger
        }

#endregion

#region Methods

        public UserToken GetStatusUser() => _userToken;

#endregion
    }
}