using E_Ticaret.Application.Abstractions.Security;

namespace E_Ticaret.Application.Abstractions.Services.Authentications
{
    public interface IExternalAuthentication
    {
        Task<TokenModel> GoogleLoginAsync(string idToken);
        Task<TokenModel> FacebookLoginAsync(string authToken);
    }
}