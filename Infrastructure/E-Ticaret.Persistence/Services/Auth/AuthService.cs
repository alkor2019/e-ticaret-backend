using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using E_Ticaret.Application.Abstractions.Security;
using E_Ticaret.Application.Abstractions.Services.AuthServices;
using E_Ticaret.Application.Abstractions.Services.UserServices;
using E_Ticaret.Application.Dtos.Facebook;
using E_Ticaret.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static Google.Apis.Auth.GoogleJsonWebSignature;

namespace E_Ticaret.Persistence.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<AppUser> _userManager;
         private readonly ITokenHelper _tokenHelper;
         private readonly HttpClient _httpClient;
         private readonly SignInManager<AppUser> _signInManager;
         private readonly IUserService _userservice;
        public AuthService(UserManager<AppUser> userManager, ITokenHelper tokenHelper, IHttpClientFactory httpClientFactory, SignInManager<AppUser> signInManager, IUserService userservice)
        {
            _userManager = userManager;
            _tokenHelper = tokenHelper;
            _httpClient = httpClientFactory.CreateClient();
            _signInManager = signInManager;
            _userservice = userservice;
        }

        public async Task<TokenModel> FacebookLoginAsync(string authToken)
        {
            string getFbAccessToken = await _httpClient.GetStringAsync($"https://graph.facebook.com/oauth/access_token?client_id={""}&client_secret={""}&grant_type=client_credentials");
            var deserializeFbAccessToken =JsonSerializer.Deserialize<FbAccessTokenDto>(getFbAccessToken);
            var getSesionInfo = await _httpClient.GetStringAsync($"https://graph.facebook.com/debug_token?input_token={authToken}&access_token={deserializeFbAccessToken.AccessToken}");
            var deserializeSesionInfo= JsonSerializer.Deserialize<FbAccessTokenValidateDto>(getSesionInfo);

            if(deserializeSesionInfo?.Data.IsValid != null)
            {
                string getUserInfo = await _httpClient.GetStringAsync($"https://graph.facebook.com/me?fields=email,first_name,last_name&access_token={authToken}");
                var  deserializeUserInfo = JsonSerializer.Deserialize<FacebookUserInfoDto>(getUserInfo);
                UserLoginInfo userLoginInfo = new("FACEBOOK", deserializeSesionInfo.Data.UserId, "FACEBOOK");
                AppUser? user = await _userManager.FindByLoginAsync(userLoginInfo.LoginProvider, userLoginInfo.ProviderKey);
                 
                return await CreateUserExternalSourceAsync(user, deserializeUserInfo.Email, deserializeUserInfo.FirstName, deserializeUserInfo.LastName, userLoginInfo);
            }
            throw new("Invalid external authentication.");
        }

        public async Task<TokenModel> GoogleLoginAsync(string idToken)
        {
            var settings = new ValidationSettings(){
                Audience = new List<string>{""}
            };
             Payload payload = await ValidateAsync(idToken, settings);
             UserLoginInfo userLoginInfo = new("GOOGLE", payload.Subject, "GOOGLE");
             AppUser? user = await _userManager.FindByLoginAsync(userLoginInfo.LoginProvider, userLoginInfo.ProviderKey);
             
             return await CreateUserExternalSourceAsync(user, payload.Email, payload.GivenName, payload.FamilyName, userLoginInfo);
        }

        public async Task<TokenModel> LoginAsync(string userNameOrEmail, string password)
        {
            var user = await _userManager.FindByEmailAsync(userNameOrEmail);
            if(user is null)
                user = await _userManager.FindByNameAsync(userNameOrEmail);
            
             if(user is null)
                    throw new ("Kullanıcı bulunamadı");
             var result = await _signInManager.CheckPasswordSignInAsync(user, password, false);

             if(!result.Succeeded)
                     throw new("Kullanıcı bilgileri doğrulanamadı!");

              var token = _tokenHelper.CreateAccessToken();
              await _userservice.UpdateRefreshTokenAsync(user, token.RefreshToken, token.Expiration, 10);       
              return  token;
        }

        public async Task<TokenModel> RefreshTokenLoginAsync(string refreshToken)
        {
            AppUser? user = await _userManager.Users.FirstOrDefaultAsync(x => x.RefreshToken == refreshToken);
            if(user != null && user?.RefreshTokenExpiration > DateTime.UtcNow)
            {
                   var token = _tokenHelper.CreateAccessToken();
                   await _userservice.UpdateRefreshTokenAsync(user, token.RefreshToken, token.Expiration, 10);
                   return token;
            }
            else
               throw new Exception("Oturum zaman aşımına uğradığı için kapatılmıştır.");
        }

        private async Task<TokenModel> CreateUserExternalSourceAsync(AppUser user, string email, string firstName, string lastName, UserLoginInfo userLoginInfo)
        {
             
             bool result = user != null;
             if(user == null)
              {
                    //user = await _userManager.FindByEmailAsync(email);
                    if(user == null)
                    {
                          user = new(){
                            FirstName = firstName,
                            LastName = lastName,
                            UserName = email.Substring(0, email.IndexOf('@')),
                            Email = email,
                          };

                          IdentityResult identityResult = await _userManager.CreateAsync(user);
                          result = identityResult.Succeeded;
                    }
                    
              }
              if(result)
                  await _userManager.AddLoginAsync(user, userLoginInfo);
              else 
                  throw new("Invalid external authentication.");

               TokenModel token = _tokenHelper.CreateAccessToken();
               await _userservice.UpdateRefreshTokenAsync(user, token.RefreshToken, token.Expiration, 10);
               return token;
        }
    }
}
