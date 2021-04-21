using System.Collections.Generic;
using Worldsys.LDI.Authorization.Delegation;
using Worldsys.LDI.Authorization.Users.Delegation.Dto;

namespace Worldsys.LDI.Web.Areas.AppName.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }
        
        public List<UserDelegationDto> UserDelegations { get; set; }
    }
}
