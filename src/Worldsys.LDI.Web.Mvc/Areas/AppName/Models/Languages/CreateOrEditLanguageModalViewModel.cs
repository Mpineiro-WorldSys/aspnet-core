using Abp.AutoMapper;
using Worldsys.LDI.Localization.Dto;

namespace Worldsys.LDI.Web.Areas.AppName.Models.Languages
{
    [AutoMapFrom(typeof(GetLanguageForEditOutput))]
    public class CreateOrEditLanguageModalViewModel : GetLanguageForEditOutput
    {
        public bool IsEditMode => Language.Id.HasValue;
    }
}