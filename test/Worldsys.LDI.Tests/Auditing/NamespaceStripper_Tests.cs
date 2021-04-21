using Worldsys.LDI.Auditing;
using Worldsys.LDI.Test.Base;
using Shouldly;
using Xunit;

namespace Worldsys.LDI.Tests.Auditing
{
    // ReSharper disable once InconsistentNaming
    public class NamespaceStripper_Tests: AppTestBase
    {
        private readonly INamespaceStripper _namespaceStripper;

        public NamespaceStripper_Tests()
        {
            _namespaceStripper = Resolve<INamespaceStripper>();
        }

        [Fact]
        public void Should_Stripe_Namespace()
        {
            var controllerName = _namespaceStripper.StripNameSpace("Worldsys.LDI.Web.Controllers.HomeController");
            controllerName.ShouldBe("HomeController");
        }

        [Theory]
        [InlineData("Worldsys.LDI.Auditing.GenericEntityService`1[[Worldsys.LDI.Storage.BinaryObject, Worldsys.LDI.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null]]", "GenericEntityService<BinaryObject>")]
        [InlineData("CompanyName.ProductName.Services.Base.EntityService`6[[CompanyName.ProductName.Entity.Book, CompanyName.ProductName.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[CompanyName.ProductName.Services.Dto.Book.CreateInput, N...", "EntityService<Book, CreateInput>")]
        [InlineData("Worldsys.LDI.Auditing.XEntityService`1[Worldsys.LDI.Auditing.AService`5[[Worldsys.LDI.Storage.BinaryObject, Worldsys.LDI.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[Worldsys.LDI.Storage.TestObject, Worldsys.LDI.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],]]", "XEntityService<AService<BinaryObject, TestObject>>")]
        public void Should_Stripe_Generic_Namespace(string serviceName, string result)
        {
            var genericServiceName = _namespaceStripper.StripNameSpace(serviceName);
            genericServiceName.ShouldBe(result);
        }
    }
}
