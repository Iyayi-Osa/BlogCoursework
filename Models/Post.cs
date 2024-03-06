using BlogCoursework.Models;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace BlogCoursework.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        [JsonIgnore]
        public User? User { get; set; }

        public List<Tag>? Tags { get; set; }
    }
}