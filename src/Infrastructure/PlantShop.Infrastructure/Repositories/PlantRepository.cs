using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using PlantShop.Domain.Models;
using PlantShop.Domain.Repositories;

namespace PlantShop.Infrastructure.Repositories;

public class PlantRepository : IPlantRepository
{
    private readonly NpgsqlConnection _connection;

    public PlantRepository(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DatabaseConnection");

        _connection = new NpgsqlConnection(connectionString);
        _connection.Open();
    }

    public async Task<IEnumerable<Plant>> GetAllAsync(int pageNumber, int pageSize)
    {
        // TODO pageable query result
        const string command = @"SELECT * FROM plant";

        var plants = await _connection.QueryAsync<Plant>(command);

        return plants;
    }

    public async Task<IEnumerable<Plant>> GetAllHotSaleAsync(Pager pager)
    {
        const string command = @"SELECT * FROM plant 
                                WHERE ishotsale = true
                                ORDER BY Id
                                OFFSET @Offset ROWS
                                FETCH NEXT @Next ROWS ONLY";


        var hotSalePlants = await _connection.QueryAsync<Plant>(command, pager);

        return hotSalePlants;
    }
}