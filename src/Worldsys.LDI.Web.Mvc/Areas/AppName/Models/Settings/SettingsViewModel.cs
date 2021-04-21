using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Worldsys.LDI.Configuration.Tenants.Dto;

namespace Worldsys.LDI.Web.Areas.AppName.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
        
        public List<string> EnabledSocialLoginSettings { get; set; } = new List<string>();
    }
}