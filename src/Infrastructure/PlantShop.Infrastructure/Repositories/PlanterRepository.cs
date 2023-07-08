using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using PlantShop.Domain.Models;
using PlantShop.Domain.Repositories;

namespace PlantShop.Infrastructure.Repositories;

public class PlanterRepository : IPlanterRepository
{
    private readonly NpgsqlConnection _connection;

    public PlanterRepository(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DatabaseConnection");

        _connection = new NpgsqlConnection(connectionString);
        _connection.Open();
    }

    public async Task<IEnumerable<Planter>> GetAllAsync(Pager pager)
    {
        const string command = @"SELECT * FROM planter
                                 ORDER BY Id
                                 OFFSET @Offset ROWS
                                 FETCH NEXT @Next ROWS ONLY";

        var planters = await _connection.QueryAsync<Planter>(command, pager);

        return planters;
    }
}
