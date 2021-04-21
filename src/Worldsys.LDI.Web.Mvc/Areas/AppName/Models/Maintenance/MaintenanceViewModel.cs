using System.Collections.Generic;
using Worldsys.LDI.Caching.Dto;

namespace Worldsys.LDI.Web.Areas.AppName.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}