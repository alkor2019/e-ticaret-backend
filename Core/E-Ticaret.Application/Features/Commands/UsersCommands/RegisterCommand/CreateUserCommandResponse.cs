using E_Ticaret.Application.Abstractions.Results;

namespace E_Ticaret.Application.Features.Commands.UsersCommands.RegisterCommand
{
    public class CreateUserCommandResponse : Result
    {
        public CreateUserCommandResponse(string message, bool success) : base(message, success)
        {
        }
    }
}