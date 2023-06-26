namespace E_Ticaret.Application.Abstractions.Security
{
    public class TokenModel
    {
        public string AccessToken { get; set; }
        
        public DateTime Expiration { get; set; }

    }
}