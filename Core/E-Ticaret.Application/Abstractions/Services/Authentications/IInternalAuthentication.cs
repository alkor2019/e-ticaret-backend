using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Abstractions.Security;

namespace E_Ticaret.Application.Abstractions.Services.Authentications
{
    public interface IInternalAuthentication
    {
        Task<TokenModel> LoginAsync(string userNameOrEmail, string password);
    }
}