using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace E_Ticaret.Application.Dtos.Facebook
{
    public class FbAccessTokenValidateDto
    {
        [JsonPropertyName("data")]
        public FbAccessTokenValidateDataDto Data { get; set; }
        
        public  class FbAccessTokenValidateDataDto
        {
            [JsonPropertyName("is_valid")]
            public bool IsValid { get; set; }

            [JsonPropertyName("user_id")]
            public string UserId { get; set; }
        }
        
    }
    // "{\"data\":{\"app_id\":\"2020750191589558\",\"type\":\"USER\",\"application\":\"Mini E-Ticaret\",\"data_access_expires_at\":1695870210,\"expires_at\":1688101200,\"is_valid\":true,\"scopes\":[\"email\",\"public_profile\"],\"user_id\":\"281645541061327\"}}"
}