using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Abstractions.Services.Authentications;

namespace E_Ticaret.Application.Abstractions.Services.AuthServices
{
    public interface IAuthService : IExternalAuthentication, IInternalAuthentication
    {
        
    }
}