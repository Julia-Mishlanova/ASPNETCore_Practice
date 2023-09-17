using Microsoft.Extensions.Configuration;

namespace ASPNETCore_Practice.Management
{
    public class ConnectionDB
    {
        public static string ConnectionString()
        {
            var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            return connectionString;
        }
    }
}
