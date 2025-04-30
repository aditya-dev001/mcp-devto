using System.Text.Json.Serialization;

namespace MCP.DevTo.Models
{
    public class Article
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("body_markdown")]
        public string? BodyMarkdown { get; set; }

        [JsonPropertyName("tags")]
        public string? Tags { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("readable_publish_date")]
        public string? ReadablePublishDate { get; set; }

        [JsonPropertyName("published")]
        public bool Published { get; set; }

        [JsonPropertyName("user")]
        public User? User { get; set; }
    }
}
