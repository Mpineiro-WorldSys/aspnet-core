﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Worldsys.LDI.Web.Areas.AppName.Models.Layout;
using Worldsys.LDI.Web.Session;
using Worldsys.LDI.Web.Views;

namespace Worldsys.LDI.Web.Areas.AppName.Views.Shared.Themes.Theme5.Components.AppNameTheme5Brand
{
    public class AppNameTheme5BrandViewComponent : LDIViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppNameTheme5BrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}