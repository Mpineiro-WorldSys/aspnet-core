using Abp.Authorization;
using Worldsys.LDI.Authorization.Roles;
using Worldsys.LDI.Authorization.Users;

namespace Worldsys.LDI.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
