# MCP - Dev.to

This project integrates with the [Dev.to API](https://developers.forem.com/api) to provide tools for interacting with articles, users, and other resources on the platform. It is built using .NET 9.0 and leverages the ModelContextProtocol framework for server-side tooling.

## Features

- Fetch latest and top articles from Dev.to.
- Search articles by tag, username, or query.
- Retrieve detailed information about articles and users.
- Create and update articles on Dev.to.
- Format responses for better readability.

## Project Structure

- **mcp-devto**: Main project containing the server and tool definitions.
- **Service**: Contains the `DevToService` implementation for interacting with the Dev.to API.
- **Model**: (Placeholder for shared models, if needed in the future).

## Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Visual Studio 2022 or any compatible IDE.
- A valid Dev.to API key.

## Setup

1. Clone the repository:
   ```bash
   git clone <repository-url>
   cd mcp-devto
   ```

2. Add your Dev.to API key to `appsettings.json`:
   ```json
   "DevTo": {
       "ApiKey": "your-api-key-here"
   }
   ```

3. Restore dependencies:
   ```bash
   dotnet restore
   ```

4. Run the project:
   ```bash
   dotnet run --project mcp-devto/mcp-devto.csproj
   ```

## Usage

### HTTP Endpoints

The project exposes HTTP endpoints for interacting with the Dev.to API. Use the `mcp-devto.http` file for testing the endpoints with tools like [REST Client](https://marketplace.visualstudio.com/items?itemName=humao.rest-client).

### MCP Server Tools

The project also provides tools accessible via the ModelContextProtocol server. These tools include:

- `GetLatestArticles`: Fetch the latest articles.
- `GetTopArticles`: Fetch top articles.
- `GetArticlesByTag`: Fetch articles by a specific tag.
- `GetArticleById`: Fetch details of an article by its ID.
- `CreateArticle`: Create a new article.

## Docker Support

The project includes a `Dockerfile` for containerization. To build and run the container:

1. Build the Docker image:
   ```bash
   docker build -t mcp-devto .
   ```

2. Run the container:
   ```bash
   docker run -p 8080:8080 -p 8081:8081 mcp-devto
   ```

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
