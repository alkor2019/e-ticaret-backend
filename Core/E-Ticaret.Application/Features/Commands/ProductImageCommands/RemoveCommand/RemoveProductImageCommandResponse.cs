using E_Ticaret.Application.Abstractions.Results;

namespace E_Ticaret.Application.Features.Commands.ProductImageCommands.RemoveCommand
{
    public class RemoveProductImageCommandResponse : Result
    {
        public RemoveProductImageCommandResponse(string message, bool success) : base(message, success)
        {
        }
    }
}