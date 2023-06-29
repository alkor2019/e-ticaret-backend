using E_Ticaret.Application.Abstractions.Results;
using E_Ticaret.Application.Abstractions.Security;

namespace E_Ticaret.Application.Features.Commands.AuthCommands.GoogleLogin
{
    public class GoogleLoginCommandResponse : DataResult<TokenModel>
    {
        public GoogleLoginCommandResponse(TokenModel data, string message, bool success) : base(data, message, success)
        {
        }
    }
}
