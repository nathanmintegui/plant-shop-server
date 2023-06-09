using Dapper;
using Npgsql;
using PlantShop.Domain.Models;
using PlantShop.Domain.Repositories;

namespace PlantShop.Infrastructure.Repositories;

public class ServiceRepository : IServiceRepository
{
    private const string ConnectionString = "Host=localhost:5432;" +
                                            "Username=pshop;" +
                                            "Password=pshop;" +
                                            "Database=pshop";

    private readonly NpgsqlConnection _connection;

    public ServiceRepository()
    {
        _connection = new NpgsqlConnection(ConnectionString);
        _connection.Open();
    }

    public async Task<IEnumerable<Services>> GetAllAsync(int pageNumber, int pageSize)
    {
        // TODO pageable query result
        const string command = @"SELECT * FROM service";

        var services = await _connection.QueryAsync<Services>(command);

        return services;
    }
}