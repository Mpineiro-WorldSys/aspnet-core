using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Worldsys.LDI.Editions.Dto;
using Worldsys.LDI.Web.Areas.AppName.Models.Common;

namespace Worldsys.LDI.Web.Areas.AppName.Models.Editions
{
    [AutoMapFrom(typeof(GetEditionEditOutput))]
    public class EditEditionModalViewModel : GetEditionEditOutput, IFeatureEditViewModel
    {
        public bool IsEditMode => Edition.Id.HasValue;

        public IReadOnlyList<ComboboxItemDto> EditionItems { get; set; }

        public IReadOnlyList<ComboboxItemDto> FreeEditionItems { get; set; }
    }
}