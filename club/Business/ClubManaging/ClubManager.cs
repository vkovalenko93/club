using club.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace club.Business.ClubManaging
{
    public class ClubManager : IClubManager
    {
        private static UserRepozitory _users;

        public ClubManager()
        {
            _users = _users ?? new UserRepozitory();
        }

        public UserRepozitory GetUsersList()
        {
            return _users;
        }

        public bool AddNewUser(User newUser)
        {
            _users.Users.Add(newUser);
            return true;
        }
    }
}
