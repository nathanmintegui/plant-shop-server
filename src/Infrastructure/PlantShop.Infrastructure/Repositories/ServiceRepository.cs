using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using PlantShop.Domain.Models;
using PlantShop.Domain.Repositories;

namespace PlantShop.Infrastructure.Repositories;

public class ServiceRepository : IServiceRepository
{
    private readonly NpgsqlConnection _connection;

    public ServiceRepository(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        _connection = new NpgsqlConnection(connectionString);
        _connection.Open();
    }

    public async Task<IEnumerable<Services>> GetAllAsync(Pager pager)
    {
        const string query = @"SELECT * FROM service
                               ORDER BY Id
                               OFFSET       @Offset ROWS
                               FETCH NEXT   @Next    ROWS ONLY";

        var services = await _connection.QueryAsync<Services>(query, pager);

        return services;
    }
}