using System.Threading.Tasks;
using Worldsys.LDI.Security.Recaptcha;

namespace Worldsys.LDI.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
