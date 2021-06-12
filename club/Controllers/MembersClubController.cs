using club.Business.ClubManaging;
using club.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace club.Controllers
{
    public class MembersClubController : BaseController
    {

        #region PrivateFields

        private readonly IClubManager _clubManager;

        #endregion

        #region Constructor

        public MembersClubController(
            ILoggerFactory loggerFactory,
            IConfiguration configuration,
            IClubManager clubManager
            ) : base(loggerFactory, configuration)
        {
            _clubManager = clubManager;
        }

        #endregion

        #region PublicaMethodos
        public IActionResult Index()
        {
            return View(new UserViewModel());
        }

        [HttpPost]
        public IActionResult Index(UserViewModel newUser)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "Something went wrong");
                    return View(newUser);
                }

                var result = CheckEmailsInRepozitory(newUser.Email);
                if (!result)
                {
                    ModelState.AddModelError("Email", "This email is already use");
                    return View(newUser);
                }

                _clubManager.AddNewUser(new User(newUser));

                return View();
            }
            catch (Exception e)
            {
                _log.LogError(e, e.Message);
                return BadRequest();
            }
        }

        [AcceptVerbs("Get", "Post")]
        public IActionResult CheckUnickEmail(string email)
        {
            bool result = CheckEmailsInRepozitory(email);
            return Json(result);
        }

        #endregion

        #region PrivateMethodos
        private bool CheckEmailsInRepozitory(string email)
        {
            var users = _clubManager.GetUsersList();
            var user = users.Users.FirstOrDefault(f => f.Email.Equals(email));
            return user == null;
        }
        #endregion
    }
}
