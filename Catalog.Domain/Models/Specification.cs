using System.Text.Json.Serialization;

namespace Catalog.Domain.Models
{
    public class Specification
    {
        [JsonPropertyName("Originally published")]
        public DateTime OriginallyPublished { get; set; }
        [JsonPropertyName("Author")]
        public string Author { get; set; }
        [JsonPropertyName("Page count")]
        public int PageCount { get; set; }
        [JsonPropertyName("Illustrator")]
        public string[] Illustrator { get; set; }
        [JsonPropertyName("Genres")]
        public string[] Genres { get; set; }
    }
}
