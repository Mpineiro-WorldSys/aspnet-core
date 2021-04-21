using System.Collections.Generic;
using Worldsys.LDI.DynamicEntityProperties.Dto;

namespace Worldsys.LDI.Web.Areas.AppName.Models.DynamicProperty
{
    public class CreateOrEditDynamicPropertyViewModel
    {
        public DynamicPropertyDto DynamicPropertyDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
