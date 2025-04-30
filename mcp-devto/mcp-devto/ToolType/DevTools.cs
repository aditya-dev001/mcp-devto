using System.ComponentModel;
using ModelContextProtocol.Server;
using Service;

namespace mcp_devto.ToolType
{
    [McpServerToolType]
    public sealed class DevTools
    {
        private readonly IDevToService _devToService;

        public DevTools(IDevToService devToService)
        {
            _devToService = devToService;
        }

        [McpServerTool, Description("Get latest articles from Dev.to")]
        public async Task<string> GetLatestArticles()
        {
            return await _devToService.GetLatestArticles();
        }

        [McpServerTool, Description("Get top articles from Dev.to")]
        public async Task<string> GetTopArticles()
        {
            return await _devToService.GetTopArticles();
        }

        [McpServerTool, Description("Get articles by tag from Dev.to")]
        public async Task<string> GetArticlesByTag([Description("The tag to search for")] string tag)
        {
            return await _devToService.GetArticlesByTag(tag);
        }

        [McpServerTool, Description("Get article details by ID")]
        public async Task<string> GetArticleById([Description("The ID of the article to retrieve")] string id)
        {
            return await _devToService.GetArticleById(id);
        }

        [McpServerTool, Description("Create a new article on Dev.to")]
        public async Task<string> CreateArticle(
            [Description("The title of the article")] string title,
            [Description("The content of the article in markdown format")] string bodyMarkdown,
            [Description("Comma-separated list of tags")] string tags = "",
            [Description("Whether to publish immediately (true) or save as draft (false)")] bool published = false)
        {
            return await _devToService.CreateArticle(title, bodyMarkdown, tags, published);
        }
    }
}
