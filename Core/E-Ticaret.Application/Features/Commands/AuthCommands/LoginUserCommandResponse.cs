using E_Ticaret.Application.Abstractions.Results;
using E_Ticaret.Application.Abstractions.Security;

namespace E_Ticaret.Application.Features.Commands.AuthCommands
{
    public class LoginUserCommandResponse : DataResult<TokenModel>
    {
        public LoginUserCommandResponse(TokenModel data, string message, bool success) : base(data, message, success)
        {
        }

      
       
       
    }
}