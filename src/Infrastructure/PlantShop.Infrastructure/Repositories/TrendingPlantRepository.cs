using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using PlantShop.Domain.Models;
using PlantShop.Domain.Repositories;

namespace PlantShop.Infrastructure.Repositories;

public class TrendingPlantRepository : ITrendingPlantRepository
{
    private readonly NpgsqlConnection _connection;

    public TrendingPlantRepository(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        _connection = new NpgsqlConnection(connectionString);
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