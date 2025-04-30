using MCP.DevTo.Models;
using System.Text;

namespace MCP.DevTo.Helpers
{
    public static class FormatHelper
    {
        public static string FormatArticles(IEnumerable<Article> articles)
        {
            if (!articles.Any())
                return "No articles found.";

            var sb = new StringBuilder("# Dev.to Articles\n\n");
            foreach (var article in articles)
            {
                sb.AppendLine($"## {article.Title}");
                sb.AppendLine($"ID: {article.Id}");
                sb.AppendLine($"Author: {article.User?.Name ?? "Unknown Author"}");
                sb.AppendLine($"Published: {article.ReadablePublishDate}");
                sb.AppendLine($"Tags: {article.Tags}");
                sb.AppendLine($"Description: {article.Description ?? "No description available."}\n");
            }

            return sb.ToString();
        }

        public static string FormatArticleDetails(Article article)
        {
            if (article == null)
                return "Article not found.";

            var sb = new StringBuilder($"# {article.Title}\n\n");
            sb.AppendLine($"Author: {article.User?.Name ?? "Unknown Author"}");
            sb.AppendLine($"Published: {article.ReadablePublishDate}");
            sb.AppendLine($"Tags: {article.Tags}\n");
            sb.AppendLine("## Content\n");
            sb.AppendLine(article.BodyMarkdown);

            return sb.ToString();
        }

        public static string FormatUserProfile(User user)
        {
            if (user == null)
                return "User not found.";

            var sb = new StringBuilder($"# {user.Name} (@{user.Username})\n\n");
            sb.AppendLine($"Bio: {user.Summary ?? "No bio available."}\n");
            
            sb.AppendLine("## Details");
            if (!string.IsNullOrEmpty(user.Location))
                sb.AppendLine($"Location: {user.Location}");
            if (!string.IsNullOrEmpty(user.JoinedAt))
                sb.AppendLine($"Member since: {user.JoinedAt}");

            sb.AppendLine("\n## Links");
            if (!string.IsNullOrEmpty(user.TwitterUsername))
                sb.AppendLine($"Twitter: @{user.TwitterUsername}");
            if (!string.IsNullOrEmpty(user.GithubUsername))
                sb.AppendLine($"GitHub: {user.GithubUsername}");
            if (!string.IsNullOrEmpty(user.WebsiteUrl))
                sb.AppendLine($"Website: {user.WebsiteUrl}");

            return sb.ToString();
        }
    }
}
