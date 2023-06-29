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
            private readonly UserManager<AppUser> _userManager;

            public CreateUserCommandHandler(UserManager<AppUser> userManager)
            {
                _userManager = userManager;
            }

            public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
            {
                var result = await _userManager.CreateAsync(new AppUser(){
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    UserName = request.UserName,
                    Email = request.Email,
                    
                }, request.Password);

                    if(result.Succeeded)
                    {
                        return  new("Kullanıcı kaydı başarıyla oluşturuldu", result.Succeeded);
                    }
                    else{
                            return  new ("Kullanıcı kaydı oluşturulurken bir hata oluştu",  result.Succeeded);
                    }
            }

        
        }
    }
}