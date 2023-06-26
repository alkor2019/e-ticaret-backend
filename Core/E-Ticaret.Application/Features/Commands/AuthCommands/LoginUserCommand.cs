using E_Ticaret.Domain.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace E_Ticaret.Application.Features.Commands.AuthCommands
{
    public class LoginUserCommandRequest:IRequest<LoginUserCommandResponse>
    {
        public string UserNameOrEmail { get; set; }
        public string Password { get; set; }



        public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
        {
            private readonly UserManager<AppUser> _userManager;
            private readonly SignInManager<AppUser> _signInManager;

            public LoginUserCommandHandler(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
            {
                _userManager = userManager;
                _signInManager = signInManager;
            }

            public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
            {
                var user = await _userManager.FindByEmailAsync(request.UserNameOrEmail);
                if(user is null)
                     user = await _userManager.FindByNameAsync(request.UserNameOrEmail);
                 
                 if(user is null)
                     return new LoginUserCommandResponse(){Message = "Kullanıcı bilgilerinizi kontrol ediniz", Succeeded = false};

                  var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
                  if(result.Succeeded)
                  {
                        return new LoginUserCommandResponse(){Message = "Giriş işlemi başarılı", Succeeded = true};

                  }
                     return new LoginUserCommandResponse(){Message = "Kullanıcı bilgilerinizi kontrol ediniz", Succeeded = false};

            }
        }
    }
}