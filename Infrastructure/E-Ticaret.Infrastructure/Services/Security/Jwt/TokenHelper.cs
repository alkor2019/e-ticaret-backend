using System.IdentityModel.Tokens.Jwt;
using System.Text;
using E_Ticaret.Application.Abstractions.Security;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace E_Ticaret.Infrastructure.Services.Security.Jwt
{
    public class TokenHelper : ITokenHelper
    {
        private readonly IConfiguration _configuration;
        public TokenHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public TokenModel CreateAccessToken()
        {
            TokenModel token = new();
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["TokenOptions:SecurityKey"]));

            SigningCredentials credentials = new(securityKey, SecurityAlgorithms.HmacSha256);

            token.Expiration = DateTime.Now.AddMinutes(int.Parse(_configuration["TokenOptions:Expiration"]));

            JwtSecurityToken jwtSecurity = new(
                 audience:_configuration["TokenOptions:Audience"],
                 issuer:_configuration["TokenOptions:Issuer"],
                 expires: token.Expiration,
                 notBefore: DateTime.UtcNow
            );
            JwtSecurityTokenHandler tokenHandler = new();
            token.AccessToken = tokenHandler.WriteToken(jwtSecurity);
            return token;
        }
    }
}