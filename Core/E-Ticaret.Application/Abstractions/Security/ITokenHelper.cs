namespace E_Ticaret.Application.Abstractions.Security
{
    public interface ITokenHelper
    {
        TokenModel CreateAccessToken();
        string CreateRefreshToken();
    }
}