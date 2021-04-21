using Microsoft.Extensions.Configuration;

namespace Worldsys.LDI.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
