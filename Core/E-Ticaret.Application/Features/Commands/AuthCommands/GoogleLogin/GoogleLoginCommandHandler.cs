using E_Ticaret.Application.Abstractions.Security;
using E_Ticaret.Domain.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using static Google.Apis.Auth.GoogleJsonWebSignature;

namespace E_Ticaret.Application.Features.Commands.AuthCommands.GoogleLogin
{
    public class GoogleLoginCommandHandler : IRequestHandler<GoogleLoginCommandRequest, GoogleLoginCommandResponse>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ITokenHelper _tokenHelper;

        public GoogleLoginCommandHandler(UserManager<AppUser> userManager, ITokenHelper tokenHelper)
        {
            _userManager = userManager;
            _tokenHelper = tokenHelper;
        }

        public async Task<GoogleLoginCommandResponse> Handle(GoogleLoginCommandRequest request, CancellationToken cancellationToken)
        {
            var settings = new ValidationSettings(){
                Audience = new List<string>{"281851454258-c3ik3s54sre97mt0miolhhc9kbmtdl9a.apps.googleusercontent.com"}
            };
             Payload payload = await ValidateAsync(request.IdToken, settings);
             UserLoginInfo userLoginInfo = new(request.Provider, payload.Subject, request.Provider);
             AppUser? user = await _userManager.FindByLoginAsync(userLoginInfo.LoginProvider, userLoginInfo.ProviderKey);
            
             bool result = user != null;
             if(user == null)
              {
                    user = await _userManager.FindByEmailAsync(payload.Email);
                    if(user == null)
                    {
                          user = new(){
                            FirstName = request.FirstName,
                            LastName = request.LastName,
                            UserName = payload.Email.Substring(0, payload.Email.IndexOf('@')),
                            Email = payload.Email,
                          };

                          IdentityResult identityResult = await _userManager.CreateAsync(user);
                          result = identityResult.Succeeded;
                    }
              }
              if(result)
                  await _userManager.AddLoginAsync(user, userLoginInfo);
              else 
                  return new(null, "Invalid external authentication.", false);

               TokenModel token = _tokenHelper.CreateAccessToken();
               return new(token, "Google girişi başarıyla yapıldı", true);
        }
    }

}
