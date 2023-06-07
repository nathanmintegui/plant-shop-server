using Dapper;
using Npgsql;

namespace PlantShop.Infrastructure.Repositories;

public class PlantRepository
{
    private const string CONNECTION_STRING = "Host=localhost:5455;" +
                                             "Username=pshop;" +
                                             "Password=pshop;" +
                                             "Database=pshop";

    private const string TABLE_NAME = "plants";

    private NpgsqlConnection _connection;

    public void DapperAdditionalDbOperations()
    {
        _connection = new NpgsqlConnection(CONNECTION_STRING);
        _connection.Open();
    }
}