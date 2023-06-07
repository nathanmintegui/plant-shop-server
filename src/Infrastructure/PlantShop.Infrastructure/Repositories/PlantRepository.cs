using Dapper;
using Npgsql;
using PlantShop.Domain.Models;
using PlantShop.Domain.Repositories;

namespace PlantShop.Infrastructure.Repositories;

public class PlantRepository : IPlantRepository
{
    private const string ConnectionString = "Host=localhost:5455;" +
                                            "Username=pshop;" +
                                            "Password=pshop;" +
                                            "Database=pshop";

    private const string TableName = "plants";

    private NpgsqlConnection _connection;

    public void DapperAdditionalDbOperations()
    {
        _connection = new NpgsqlConnection(ConnectionString);
        _connection.Open();
    }

    public async Task<IEnumerable<Plant>> GetAllAsync(int pageNumber, int pageSize)
    {
        // TODO pageable query result
        const string command = $"SELECT * FROM plant";

        var plants = await _connection.QueryAsync<Plant>(command);

        return plants;
    }
}