using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace BlogCoursework.Models
{
    
    public class Category
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        [JsonIgnore]
        public List<Tag>? Tags { get; set; }
    }
}