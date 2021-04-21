using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Worldsys.LDI.Configuration.Host.Dto;
using Worldsys.LDI.Editions.Dto;

namespace Worldsys.LDI.Web.Areas.AppName.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }

        public List<string> EnabledSocialLoginSettings { get; set; } = new List<string>();
    }
}