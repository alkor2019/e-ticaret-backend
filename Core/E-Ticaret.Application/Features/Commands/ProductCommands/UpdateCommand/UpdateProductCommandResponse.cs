using E_Ticaret.Application.Abstractions.Results;

namespace E_Ticaret.Application.Features.Commands.ProductCommands.UpdateCommand
{
    public class UpdateProductCommandResponse : Result
    {
        public UpdateProductCommandResponse(string message, bool success) : base(message, success)
        {
        }
    }

}