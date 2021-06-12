using club.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace club.Business.ClubManaging
{
    public interface IClubManager
    {
        UserRepozitory GetUsersList();

        bool AddNewUser(User newUser);
    }
}
