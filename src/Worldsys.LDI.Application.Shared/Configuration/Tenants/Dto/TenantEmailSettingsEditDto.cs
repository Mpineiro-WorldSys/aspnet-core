using Abp.Auditing;
using Worldsys.LDI.Configuration.Dto;

namespace Worldsys.LDI.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}