using club.Business.ClubManaging;
using club.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;

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
            IClubManager clubManager
            ) : base(loggerFactory)
        {
            _clubManager = clubManager;
        }

        #endregion

        #region PublicaMethodos

        public IActionResult Index()
        {
            return View();
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

                if (!CheckEmailsInRepozitory(newUser.Email))
                {
                    ModelState.AddModelError("Email", "This email is already use");
                    return View(newUser);
                }

                _clubManager.AddNewUser(new User(newUser));
                _log.LogInformation($"inserted new user: {JsonSerializer.Serialize(newUser)}");

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
            return Json(CheckEmailsInRepozitory(email));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
