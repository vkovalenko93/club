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
    public class BaseController : Controller
    {

        #region Protected Fields

        protected readonly ILogger _log;

        #endregion


        #region Construrtors

        /// <summary>
        /// Default contructor
        /// </summary>
        public BaseController()
        {

        }

        /// <summary>
        /// Contructor with params
        /// </summary>
        /// <param name="loggerFactory">The logger factory.</param>
        public BaseController(ILoggerFactory loggerFactory)
        {
            _log = loggerFactory.CreateLogger("BaseController");
        }

        #endregion
    }
}
