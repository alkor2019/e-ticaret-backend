using E_Ticaret.Application.Abstractions.Results;
using E_Ticaret.Application.Abstractions.Security;

namespace E_Ticaret.Application.Features.Commands.AuthCommands.RefreshTokenLoginCommands
{
    public class RefreshTokenLoginCommandResponse : DataResult<TokenModel>
    {
        public RefreshTokenLoginCommandResponse(TokenModel data, string message, bool success) : base(data, message, success)
        {
        }
    }
}