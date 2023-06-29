using E_Ticaret.Application.Abstractions.Results;

namespace E_Ticaret.Application.Features.Commands.ProductImageCommands.UploadCommand
{
    public class UploadProductImageCommandResponse : Result
    {
        public UploadProductImageCommandResponse(string message, bool success) : base(message, success)
        {
        }
    }
}