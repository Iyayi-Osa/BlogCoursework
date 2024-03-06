using BlogCoursework.Models;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlogCoursework.Models
{
    public class UserType
    {
        public int UserTypeId { get; set; }
        public string? UserTypeName { get; set; }
        [JsonIgnore]
        public List<User>? Users { get; set; }
    }    
}