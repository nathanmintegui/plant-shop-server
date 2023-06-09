using PlantShop.Domain.Models;

namespace PlantShop.Domain.Repositories;

public interface IPlantRepository
{
    Task<IEnumerable<Plant>> GetAllAsync(int pageNumber, int pageSize);
    Task<IEnumerable<Plant>> GetAllHotSaleAsync(int pageNumber, int pageSize);
}