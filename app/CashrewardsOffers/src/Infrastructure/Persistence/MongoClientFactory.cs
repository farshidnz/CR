using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace CashrewardsOffers.Infrastructure.Persistence
{
    public interface IMongoClientFactory
    {
        MongoClient CreateClient();
    }

    public class MongoClientFactory : IMongoClientFactory
    {
        private readonly IConfiguration _configuration;

        public MongoClientFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public MongoClient CreateClient()
        {
            string username = _configuration["DocumentDbUsername"];
            string password = _configuration["DocumentDbPassword"];
            string docDbHost = _configuration["DocumentDBHostWriter"];
            string connectionString = string.Format(_configuration.GetConnectionString("DocumentDbConnectionString"), username, password, docDbHost);

            var settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
            return new MongoClient(settings);
        }
    }
}
