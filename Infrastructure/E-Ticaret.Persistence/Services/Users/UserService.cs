using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Abstractions.Services.UserServices;
using E_Ticaret.Application.Dtos.Users;
using E_Ticaret.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace E_Ticaret.Persistence.Services.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;

        public UserService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<CreateUserResponseDto> CreateUserAsync(CreateUserDto model)
        {
            var result = await _userManager.CreateAsync(new AppUser(){
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    UserName = model.UserName,
                    Email = model.Email,
                    
                }, model.Password);
                var response = new CreateUserResponseDto();
                    if(result.Succeeded)
                    {
                        response.Message = "Kullanıcı kaydı başarıyla oluşturuldu";
                        response.Success = result.Succeeded;
                    }
                    else{
                           response.Message = "Kullanıcı kaydı oluşturulurken bir hata oluştu";
                           response.Success =  result.Succeeded;
                    }
                return response;
        }
    }
}