using System.Threading.Tasks;

namespace Worldsys.LDI.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
