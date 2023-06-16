using Dapper;
using Npgsql;
using PlantShop.Domain.Models;
using PlantShop.Domain.Repositories;

namespace PlantShop.Infrastructure.Repositories;

public class TrendingPlantRepository : ITrendingPlantRepository
{
    private const string ConnectionString = "Host=localhost:5432;" +
                                            "Username=pshop;" +
                                            "Password=pshop;" +
                                            "Database=pshop";

    private readonly NpgsqlConnection _connection;

    public TrendingPlantRepository()
    {
        _connection = new NpgsqlConnection(ConnectionString);
        _connection.Open();
    }

    public async Task<IEnumerable<Plant>> GetAllAsync(Pager pager)
    {
        const string query = @"SELECT * FROM plant
                               ORDER BY Id
                               OFFSET      @Offset  ROWS 
                               FETCH NEXT  @Next    ROWS ONLY";

        var plants = await _connection.QueryAsync<Plant>(query, pager);

        return plants;
    }
}