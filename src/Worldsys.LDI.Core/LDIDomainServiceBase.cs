using Abp.Domain.Services;

namespace Worldsys.LDI
{
    public abstract class LDIDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected LDIDomainServiceBase()
        {
            LocalizationSourceName = LDIConsts.LocalizationSourceName;
        }
    }
}
