using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public class User
    {
        public User()
        {
            RefreshTokens = new List<RefreshToken>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }

        [JsonIgnore]
        public string Password { get; set; }
        
        [JsonIgnore]
        [NotMapped]
        public List<RefreshToken> RefreshTokens { get; set; }
    }
}