using System.Text.Json.Serialization;

namespace MCP.DevTo.Models
{
    public class User
    {
        [JsonPropertyName("username")]
        public string? Username { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("summary")]
        public string? Summary { get; set; }

        [JsonPropertyName("twitter_username")]
        public string? TwitterUsername { get; set; }

        [JsonPropertyName("github_username")]
        public string? GithubUsername { get; set; }

        [JsonPropertyName("website_url")]
        public string? WebsiteUrl { get; set; }

        [JsonPropertyName("location")]
        public string? Location { get; set; }

        [JsonPropertyName("joined_at")]
        public string? JoinedAt { get; set; }
    }
}
