using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Worldsys.LDI.Editions.Dto;

namespace Worldsys.LDI.Web.Areas.AppName.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}