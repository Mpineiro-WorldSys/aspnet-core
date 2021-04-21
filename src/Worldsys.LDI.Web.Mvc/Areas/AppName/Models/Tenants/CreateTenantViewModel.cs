using System.Collections.Generic;
using Worldsys.LDI.Editions.Dto;
using Worldsys.LDI.Security;

namespace Worldsys.LDI.Web.Areas.AppName.Models.Tenants
{
    public class CreateTenantViewModel
    {
        public IReadOnlyList<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public CreateTenantViewModel(IReadOnlyList<SubscribableEditionComboboxItemDto> editionItems)
        {
            EditionItems = editionItems;
        }
    }
}