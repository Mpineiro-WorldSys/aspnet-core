using System.Collections.Generic;
using Abp.Localization;
using Worldsys.LDI.Install.Dto;

namespace Worldsys.LDI.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
