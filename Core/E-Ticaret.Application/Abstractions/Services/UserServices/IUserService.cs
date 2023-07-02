using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Dtos.Users;

namespace E_Ticaret.Application.Abstractions.Services.UserServices
{
    public interface IUserService
    {
        Task<CreateUserResponseDto> CreateUserAsync(CreateUserDto model);
        
    }
}