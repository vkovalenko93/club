using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace club.Models
{
    public class UserRepozitory
    {
        public List<User> Users { get; set; }

        public UserRepozitory()
        {
            Users = new List<User>();
        }
    }
}
