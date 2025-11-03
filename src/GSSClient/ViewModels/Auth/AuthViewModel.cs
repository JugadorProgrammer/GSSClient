using GSSClient.Domain.Connection;
using GSSClient.Domain.Entities;
using ReactiveUI;
using ReactiveUI.SourceGenerators;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GSSClient.ViewModels.Auth
{
    public partial class AuthViewModel : ViewModelBase
    {
        private readonly IAuthService _authService;

        [Reactive]
        public partial string Login { get; set; }

        [Reactive]
        public partial string Password { get; set; }

        [Reactive]
        public partial string ErrorMessage { get; set; }

        public ICommand LoginCommand { get; }

        public ICommand SingUpCommand { get; }

        public AuthViewModel(IAuthService authService) 
        {
            _authService = authService;

            Login = string.Empty;
            Password = string.Empty;
            ErrorMessage = string.Empty;

            LoginCommand = ReactiveCommand.CreateFromTask(LoginUser);
            SingUpCommand = ReactiveCommand.CreateFromTask(SingUpUser);
        }

        private async Task LoginUser()
        {
            var user = new User()
            { 
                Login = Login,
                Password = Password
            };

            var result = await _authService.Login(user);
            switch (result)
            {
                case Domain.Results.LoginResult.Failed:
                    ErrorMessage = "User not found";
                    break;
                case Domain.Results.LoginResult.ConnectionFailed:
                    ErrorMessage = "Connection lost";
                    break;
                case Domain.Results.LoginResult.Success:
                    break;
                default:
                    break; // TODO: придумать какой exception бросать, когда придумаю,как правильно падать
            }
        }

        private async Task SingUpUser()
        {
            var user = new User()
            {
                Login = Login,
                Password = Password
            };

            var result = await _authService.SingUp(user);
            switch (result)
            {
                case Domain.Results.SingUpResult.InvalidEmail:
                    ErrorMessage = "Invalid email";
                    break;
                case Domain.Results.SingUpResult.InvalidPassword:
                    ErrorMessage = "Invalid password";
                    break;
                case Domain.Results.SingUpResult.UserAlreadyExists:
                    ErrorMessage = "User already exists";
                    break;
                case Domain.Results.SingUpResult.ConnectionFailed:
                    ErrorMessage = "Connection lost";
                    break;
            }
        }
    }
}
