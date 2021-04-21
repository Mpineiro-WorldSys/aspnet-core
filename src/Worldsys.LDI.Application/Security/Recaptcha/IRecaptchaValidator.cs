using System.Threading.Tasks;

namespace Worldsys.LDI.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}