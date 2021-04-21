using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Worldsys.LDI.Authorization.Users;
using Worldsys.LDI.MultiTenancy;

namespace Worldsys.LDI.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}