using club.Business.ClubManaging;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace club.Components
{
    public class MembersViewComponent : ViewComponent
    {

        private readonly IClubManager _clubManager;

        public MembersViewComponent(
            IClubManager clubManager
            )
        {
            _clubManager = clubManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = _clubManager.GetUsersList();
            return View(model);
        }
    }
}
