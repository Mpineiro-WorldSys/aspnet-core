using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using Worldsys.LDI.Dto;

namespace Worldsys.LDI.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
