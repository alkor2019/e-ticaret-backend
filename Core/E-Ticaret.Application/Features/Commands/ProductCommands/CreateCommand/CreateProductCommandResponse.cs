using E_Ticaret.Application.Abstractions.Results;

namespace E_Ticaret.Application.Features.Commands.ProductCommands.CreateCommand
{
    public class CreateProductCommandResponse : Result
    {
        public CreateProductCommandResponse(string message, bool success) : base(message, success)
        {
             
        }
    }
}