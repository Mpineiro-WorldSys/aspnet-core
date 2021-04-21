using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Worldsys.LDI.Editions.Dto;

namespace Worldsys.LDI.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}