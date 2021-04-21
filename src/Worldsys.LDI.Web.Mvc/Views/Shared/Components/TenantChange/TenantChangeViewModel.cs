using Abp.AutoMapper;
using Worldsys.LDI.Sessions.Dto;

namespace Worldsys.LDI.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}