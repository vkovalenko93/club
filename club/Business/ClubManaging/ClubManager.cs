using club.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace club.Business.ClubManaging
{
    public class ClubManager : IClubManager
    {

        #region PrivateFields

        private static UserRepozitory _users;


        #endregion

        #region Contructor

        public ClubManager()
        {
            _users = _users ?? new UserRepozitory();
        }

        #endregion

        #region PublicMethodos

        public UserRepozitory GetUsersList()
        {
            return _users;
        }

        public bool AddNewUser(User newUser)
        {
            _users.Users.Add(newUser);
            return true;
        }

        #endregion
    }
}
