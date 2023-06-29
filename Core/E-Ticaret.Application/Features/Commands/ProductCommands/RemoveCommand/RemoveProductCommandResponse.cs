using E_Ticaret.Application.Abstractions.Results;

namespace E_Ticaret.Application.Features.Commands.ProductCommands.RemoveCommand
{
    public class RemoveProductCommandResponse : Result
    {
        public RemoveProductCommandResponse(string message, bool success) : base(message, success)
        {
        }
    }
}