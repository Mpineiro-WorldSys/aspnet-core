using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Threading.Tasks;
using Worldsys.LDI.Phonebook.Dto;

namespace Worldsys.LDI.Phonebook
{
    public interface IPersonAppService : IApplicationService
    {
        ListResultDto<PersonListDto> GetPeople(GetPeopleInput input);
        Task CreatePerson(CreatePersonInput input);
        Task DeletePerson(EntityDto input);
        Task DeletePhone(EntityDto<long> input);
        Task<PhoneInPersonListDto> AddPhone(AddPhoneInput input);
    }

}
