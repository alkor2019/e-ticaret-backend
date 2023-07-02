using E_Ticaret.Application.Abstractions.Security;
using E_Ticaret.Application.Abstractions.Services.Authentications;
using E_Ticaret.Domain.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace E_Ticaret.Application.Features.Commands.AuthCommands.LoginCommands
{
    public class LoginUserCommandRequest:IRequest<LoginUserCommandResponse>
    {
        public string UserNameOrEmail { get; set; }
        public string Password { get; set; }



        public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
        {
            private readonly IInternalAuthentication _internalAuthentication;

            public LoginUserCommandHandler(IInternalAuthentication internalAuthentication)
            {
                _internalAuthentication = internalAuthentication;
            }

            public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
            {
                 try
                 {
                    var token = await  _internalAuthentication.LoginAsync(request.UserNameOrEmail, request.Password);
                    return new(token, "Kullanıcı girişi yapıldı", true);
                 }
                 catch (Exception ex)
                 {
                      // TODO
                      return new(null, ex.Message, false);
                 }
            }
        }
    }
}