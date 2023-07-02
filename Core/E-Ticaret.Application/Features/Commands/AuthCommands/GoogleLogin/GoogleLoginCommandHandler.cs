using E_Ticaret.Application.Abstractions.Security;
using E_Ticaret.Application.Abstractions.Services.AuthServices;
using E_Ticaret.Domain.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace E_Ticaret.Application.Features.Commands.AuthCommands.GoogleLogin
{
    public class GoogleLoginCommandHandler : IRequestHandler<GoogleLoginCommandRequest, GoogleLoginCommandResponse>
    {
        private readonly IAuthService _authService;

        public GoogleLoginCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<GoogleLoginCommandResponse> Handle(GoogleLoginCommandRequest request, CancellationToken cancellationToken)
        {
             try
             {
                 var token = await _authService.GoogleLoginAsync(request.IdToken);
                 return new(token, "Google girişi yapıldı", true);
             }
             catch (Exception ex)
             {
                  // TODO
                  return new(null, ex.Message, false);
             }
        }
    }

}
