using System.Threading.Tasks;

namespace Survey.Application.Common
{
    public interface IIdentityService
    {
        Task Register(string email, string password);
    }
}