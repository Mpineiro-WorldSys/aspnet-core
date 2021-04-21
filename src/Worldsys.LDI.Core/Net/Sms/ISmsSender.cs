using System.Threading.Tasks;

namespace Worldsys.LDI.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}