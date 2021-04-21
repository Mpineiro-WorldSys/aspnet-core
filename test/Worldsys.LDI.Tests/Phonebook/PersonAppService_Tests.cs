using Abp.Runtime.Validation;
using Shouldly;
using System.Linq;
using System.Threading.Tasks;
using Worldsys.LDI.Phonebook;
using Worldsys.LDI.Phonebook.Dto;
using Xunit;

namespace Worldsys.LDI.Tests.Phonebook
{
    public class PersonAppService_Tests : AppTestBase
    {
        private readonly IPersonAppService _personAppService;

        public PersonAppService_Tests()
        {
            _personAppService = Resolve<IPersonAppService>();
        }

        [Fact]
        public void Should_Get_All_People_Without_Any_Filter()
        {
            //Act
            var persons = _personAppService.GetPeople(new GetPeopleInput());

            //Assert
            persons.Items.Count.ShouldBe(2);
        }

        [Fact]
        public void Should_Get_All_People_With_Filter()
        {
            //Act
            var persons = _personAppService.GetPeople(new GetPeopleInput { Filter = "adams"});

            //Assert
            persons.Items.Count.ShouldBe(1);
            persons.Items[0].Name.ShouldBe("Douglas");
            persons.Items[0].Surname.ShouldBe("Adams");
        }

        [Fact]
        public async Task Should_Create_Person_With_Valid_Arguments()
        {
            //Act
            await _personAppService.CreatePerson(
            new CreatePersonInput
        {
            Name = "John",
            Surname = "Nash",
            EmailAddress = "john.nash@abeautifulmind.com"
        });

            //Assert
            UsingDbContext(
                context =>
                {
                    var john = context.Persons.FirstOrDefault(p => p.EmailAddress == "john.nash@abeautifulmind.com");
                    john.ShouldNotBe(null);
                    john.Name.ShouldBe("John");
                });
        }
        [Fact]
        public async Task Should_Not_Create_Person_With_Invalid_Arguments()
        {
            //Act and Assert
            await Assert.ThrowsAsync<AbpValidationException>(
                async () =>
                {
                    await _personAppService.CreatePerson(
                    new CreatePersonInput
                    {
                        Name = "John"
                    });
                });
        }
    }
}
