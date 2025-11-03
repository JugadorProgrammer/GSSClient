using GSSClient.Domain.Connection;
using GSSClient.Domain.Entities;
using GSSClient.Domain.Results;

namespace GSSClient.Infrastructure.Connection
{
    public class AuthService : IAuthService
    {
        public Task<LoginResult> Login(User user)
        {
            throw new NotImplementedException();
        }

        public Task<LogoutResult> Logout()
        {
            throw new NotImplementedException();
        }

        public Task<SingUpResult> SingUp(User user)
        {
            throw new NotImplementedException();
        }
    }
}
