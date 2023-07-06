using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;
using E_Ticaret.Application.Abstractions.Security;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace E_Ticaret.Infrastructure.Services.Security.Jwt
{
    public class TokenHelper : ITokenHelper
    {
      
        private readonly TokenOptions _tokenOptions;
        public TokenHelper(IConfiguration configuration)
        {
            
            _tokenOptions = configuration.GetSection("TokenOptions").Get<TokenOptions>();
        }
        public TokenModel CreateAccessToken()
        {
            TokenModel token = new();
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenOptions.SecurityKey));
  
            SigningCredentials signingCredentials = new(securityKey, SecurityAlgorithms.HmacSha256);

            token.Expiration = DateTime.Now.AddSeconds(_tokenOptions.Expiration);

            JwtSecurityToken jwtSecurity = new(
                 audience:_tokenOptions.Audience,
                 issuer:_tokenOptions.Issuer,
                 expires: token.Expiration,
                 signingCredentials: signingCredentials,
                 notBefore: DateTime.UtcNow
            );
            JwtSecurityTokenHandler tokenHandler = new();
            token.AccessToken = tokenHandler.WriteToken(jwtSecurity);
            token.RefreshToken = CreateRefreshToken();
            return token;
        }

        public string CreateRefreshToken()
        {
            byte[] numbers = new byte[32];
            RandomNumberGenerator random = RandomNumberGenerator.Create();
            random.GetBytes(numbers);
            return  Convert.ToBase64String(numbers);
        }
    }
}