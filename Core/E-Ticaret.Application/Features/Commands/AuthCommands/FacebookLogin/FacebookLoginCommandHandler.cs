using System.Text.Json;
using E_Ticaret.Application.Abstractions.Security;
using E_Ticaret.Application.Abstractions.Services.AuthServices;
using E_Ticaret.Application.Dtos.Facebook;
using E_Ticaret.Domain.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace E_Ticaret.Application.Features.Commands.AuthCommands.FacebookLogin
{
    public class FacebookLoginCommandHandler : IRequestHandler<FacebookLoginCommandRequest, FacebookLoginCommandResponse>
    {
         private readonly IAuthService _authService;

        public FacebookLoginCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<FacebookLoginCommandResponse> Handle(FacebookLoginCommandRequest request, CancellationToken cancellationToken)
        {
            
            try
            {
                var token = await _authService.FacebookLoginAsync(request.AuthToken);
                return new(token, "Facebook girişi başarıyla tamamlandı", true);
            }
            catch(Exception ex)
            {
                 // TODO
                 return new(null, ex.Message, false);
            }
        }
    }
}