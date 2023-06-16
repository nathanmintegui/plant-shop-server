using PlantShop.Domain.Models;

namespace PlantShop.Domain.Repositories;

public interface ITrendingPlantRepository
{
    Task<IEnumerable<Plant>> GetAllAsync(Pager pager);
}