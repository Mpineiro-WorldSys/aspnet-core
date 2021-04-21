using System.Collections.Generic;
using Worldsys.LDI.Editions.Dto;
using Worldsys.LDI.MultiTenancy.Dto;

namespace Worldsys.LDI.Web.Areas.AppName.Models.Tenants
{
    public class EditTenantViewModel
    {
        public TenantEditDto Tenant { get; set; }

        public IReadOnlyList<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public EditTenantViewModel(TenantEditDto tenant, IReadOnlyList<SubscribableEditionComboboxItemDto> editionItems)
        {
            Tenant = tenant;
            EditionItems = editionItems;
        }
    }
}