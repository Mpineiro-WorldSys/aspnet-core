using Abp.AutoMapper;
using Worldsys.LDI.MultiTenancy;
using Worldsys.LDI.MultiTenancy.Dto;
using Worldsys.LDI.Web.Areas.AppName.Models.Common;

namespace Worldsys.LDI.Web.Areas.AppName.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}