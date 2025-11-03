using GSSClient.Domain.Entities;
using GSSClient.Domain.Results;

namespace GSSClient.Domain.Connection
{
    public interface IAuthService
    {
        Task<SingUpResult> SingUp(User user);

        Task<LoginResult> Login(User user);

        Task<LogoutResult> Logout();
    }
}
