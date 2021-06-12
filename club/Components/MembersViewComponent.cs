using club.Business.ClubManaging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace club.Components
{
    public class MembersViewComponent : BaseViewComponent
    {
        #region PrivateFields

        private readonly IClubManager _clubManager;

        #endregion

        #region Contructors

        public MembersViewComponent(
            IClubManager clubManager,
            ILoggerFactory loggerFactory
            ) : base(loggerFactory)
        {
            _clubManager = clubManager;
        }

        #endregion


        #region Methodos

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = _clubManager.GetUsersList();
            _log.LogInformation($"Users list: {JsonSerializer.Serialize(model)}");
            return View(model);
        }

        #endregion
    }
}
