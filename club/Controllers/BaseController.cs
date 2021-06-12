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
        protected readonly IMemoryCache _cache;
        private readonly IConfiguration _configuration;

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
        /// <param name="cache">The cache.</param>
        /// <param name="configuration">The configuration.</param>
        public BaseController(ILoggerFactory loggerFactory, IMemoryCache cache, IConfiguration configuration)
        {
            _log = loggerFactory.CreateLogger("BaseController");
            _cache = cache;
            _configuration = configuration;
        }

        #endregion
    }
}
