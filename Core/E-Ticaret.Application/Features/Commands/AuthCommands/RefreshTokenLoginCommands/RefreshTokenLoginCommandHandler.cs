using E_Ticaret.Application.Abstractions.Services.AuthServices;
using MediatR;

namespace E_Ticaret.Application.Features.Commands.AuthCommands.RefreshTokenLoginCommands
{
    public class RefreshTokenLoginCommandHandler : IRequestHandler<RefreshTokenLoginCommandRequest, RefreshTokenLoginCommandResponse>
    {
        private readonly IAuthService _authService;

        public RefreshTokenLoginCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<RefreshTokenLoginCommandResponse> Handle(RefreshTokenLoginCommandRequest request, CancellationToken cancellationToken)
        {
             try
             {
                 var token = await _authService.RefreshTokenLoginAsync(request.RefreshToken);
                 return new(token, null, true);
             }
             catch (Exception ex)
             {
                  // TODO
                  throw new Exception(ex.Message);
             }
        }
    }
}