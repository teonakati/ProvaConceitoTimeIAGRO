using System.Text.Json.Serialization;

namespace Catalog.Domain.Models
{
    public class Book
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("price")]
        public double Price { get; set; }
        [JsonPropertyName("specifications")]
        public Specification Specifications { get; set; }
        
    }
}
