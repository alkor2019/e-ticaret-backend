using E_Ticaret.Application.Abstractions.Results;
using E_Ticaret.Application.Abstractions.Security;

namespace E_Ticaret.Application.Features.Commands.AuthCommands.FacebookLogin
{
    public class FacebookLoginCommandResponse : DataResult<TokenModel>
    {
        public FacebookLoginCommandResponse(TokenModel data, string message, bool success) : base(data, message, success)
        {
        }
    }
}