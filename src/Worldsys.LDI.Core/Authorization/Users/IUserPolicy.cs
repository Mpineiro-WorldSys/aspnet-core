using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace Worldsys.LDI.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
