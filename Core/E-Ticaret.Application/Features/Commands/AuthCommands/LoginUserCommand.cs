using E_Ticaret.Application.Abstractions.Security;
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
            private readonly ITokenHelper _tokenHelper;

            public LoginUserCommandHandler(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ITokenHelper tokenHelper)
            {
                _userManager = userManager;
                _signInManager = signInManager;
                _tokenHelper = tokenHelper;
            }

            public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
            {
                 var user = await _userManager.FindByEmailAsync(request.UserNameOrEmail);
            if(user is null)
                user = await _userManager.FindByNameAsync(request.UserNameOrEmail);
            
             if(user is null)
                    return new (null, "Kullanıcı bulunamadı", false);
             var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

             if(!result.Succeeded)
                     return new(null, "Kullanıcı bilgileri doğrulanamadı!", false);

              var token = _tokenHelper.CreateAccessToken();       
              return new(token, "Kullanıcı girişi başarıyla yapıldı", true);
            }
        }
    }
}