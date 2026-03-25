using Microsoft.Extensions.Configuration;

namespace RazorApp.Data;

public static class ConfigurationExtensions
{
    extension(IConfiguration configuration)
    {
        public string? GetSqliteConnection()
        {
            var path = configuration["Database:Path"];

            return !string.IsNullOrEmpty(path) ? $"Data Source={path}" : null;
        }
    }
}
