using System.Threading.Tasks;
using Worldsys.LDI.Sessions.Dto;

namespace Worldsys.LDI.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
