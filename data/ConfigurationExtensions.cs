using Microsoft.Extensions.Configuration;

namespace RazorApp.Data;

public static class ConfigurationExtensions
{
    extension(IConfiguration configuration)
    {
        public string? GetSqliteConnection()
        {
            var connection = configuration["ConnectionString"];
            if (!string.IsNullOrEmpty(connection))
            {
                return connection;
            }

            var path = configuration["Database:Path"];
            return !string.IsNullOrEmpty(path) ? $"Data Source={path}" : null;
        }
    }
}
