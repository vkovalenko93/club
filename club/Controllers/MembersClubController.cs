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


        #region Constructor

        public MembersClubController(
            ILoggerFactory loggerFactory,
            IMemoryCache cache,
            IConfiguration configuration
            ) : base(loggerFactory, cache, configuration)
        {

        }

        #endregion

        #region PrivateMethodos
        #endregion

        #region PublicaMethodos
        public IActionResult Index()
        {
            return View();
        }

        #endregion
    }
}
