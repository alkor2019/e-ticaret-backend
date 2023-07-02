using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace E_Ticaret.Application.Dtos.Facebook
{
    public class FacebookUserInfoDto
    {
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }
        
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        
        [JsonPropertyName("email")]
        public string Email { get; set; }
        
        
    }
}