using System.Collections.Generic;
using Worldsys.LDI.DynamicEntityProperties.Dto;

namespace Worldsys.LDI.Web.Areas.AppName.Models.DynamicEntityProperty
{
    public class CreateEntityDynamicPropertyViewModel
    {
        public string EntityFullName { get; set; }

        public List<string> AllEntities { get; set; }

        public List<DynamicPropertyDto> DynamicProperties { get; set; }
    }
}
