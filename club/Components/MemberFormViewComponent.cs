using club.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace club.Components
{
    public class MemberFormViewComponent : BaseViewComponent
    {

        #region Contructor

        public MemberFormViewComponent(
            ILoggerFactory loggerFactory
            ) : base(loggerFactory)
        {

        }

        #endregion

        #region Methodos

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(new UserViewModel());
        }

        #endregion
    }
}
