using System.Globalization;

namespace Worldsys.LDI.Localization
{
    public interface IApplicationCulturesProvider
    {
        CultureInfo[] GetAllCultures();
    }
}