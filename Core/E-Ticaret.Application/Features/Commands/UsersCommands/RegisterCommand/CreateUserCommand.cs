using E_Ticaret.Application.Abstractions.Services.UserServices;
using E_Ticaret.Domain.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace E_Ticaret.Application.Features.Commands.UsersCommands.RegisterCommand
{
    public class CreateUserCommandRequest:IRequest<CreateUserCommandResponse>
     {
          public string FirstName { get; set; }
          public string LastName { get; set; }
          public string UserName { get; set; }
          public string Email { get; set; }
          public string Password { get; set; }
          

        public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
        {
            private readonly IUserService _userService;

            public CreateUserCommandHandler(IUserService userService)
            {
                _userService = userService;
            }

            public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
            {
                var result = await _userService.CreateUserAsync(new(){
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    UserName = request.UserName,
                    Email = request.Email,
                    Password = request.Password
                });
                return new(result.Message, result.Success);
            }

        
        }
    }
}