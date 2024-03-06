
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace BlogCoursework.Models
{
    public class Tag
    {
         public int TagId { get; set; }
        public int PostId { get; set; }
        public int CategoryId { get; set; }
        [JsonIgnore]
        public Post? Post { get; set; }
        public Category? Category { get; set; }
    }
}