using Dapper;
using Npgsql;
using PlantShop.Domain.Models;
using PlantShop.Domain.Repositories;

namespace PlantShop.Infrastructure.Repositories;

public class PlanterRepository : IPlanterRepository
{
    private const string ConnectionString = "Host=localhost:5432;" +
                                            "Username=pshop;" +
                                            "Password=pshop;" +
                                            "Database=pshop";

    private readonly NpgsqlConnection _connection;

    public PlanterRepository()
    {
        _connection = new NpgsqlConnection(ConnectionString);
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