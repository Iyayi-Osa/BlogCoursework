
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace BlogCoursework.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string? Name { get; set; }
         public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        [JsonIgnore]
        public List<Post>? Posts { get; set; }
    }
}