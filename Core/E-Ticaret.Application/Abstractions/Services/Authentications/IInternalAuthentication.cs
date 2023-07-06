using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Abstractions.Security;
using E_Ticaret.Domain.Entities.Identity;

namespace E_Ticaret.Application.Abstractions.Services.Authentications
{
    public interface IInternalAuthentication
    {
        Task<TokenModel> LoginAsync(string userNameOrEmail, string password);
        Task<TokenModel> RefreshTokenLoginAsync(string refreshToken);
        
    }
}