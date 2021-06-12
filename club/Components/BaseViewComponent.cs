using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace club.Components
{
    public abstract class BaseViewComponent : ViewComponent
    {
        #region Proterted Fields

        protected readonly ILogger _log;

        #endregion

        #region Constructors

        public BaseViewComponent()
        {

        }

        public BaseViewComponent(ILoggerFactory loggerFactory)
        {
            _log = loggerFactory.CreateLogger("BaseViewComponent");
        }

        #endregion
    }
}
