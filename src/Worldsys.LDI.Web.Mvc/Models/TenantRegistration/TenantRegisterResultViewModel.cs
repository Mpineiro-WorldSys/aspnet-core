using Abp.AutoMapper;
using Worldsys.LDI.MultiTenancy.Dto;

namespace Worldsys.LDI.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}