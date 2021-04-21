using Abp.AutoMapper;
using Worldsys.LDI.MultiTenancy.Dto;

namespace Worldsys.LDI.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
