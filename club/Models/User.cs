using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace club.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }

        public User(UserViewModel user)
        {
            Name = user.Name;
            Email = user.Email;
            RegistrationDate = DateTime.Now.Date;
        }
    }
}
