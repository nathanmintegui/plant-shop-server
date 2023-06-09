using PlantShop.Domain.Models;

namespace PlantShop.Domain.Repositories;

public interface ITrendingPlantRepository
{
    Task<IEnumerable<Plant>> GetAllAsync(int pageNumber, int pageSize);
}