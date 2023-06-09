using PlantShop.Domain.Models;

namespace PlantShop.Application.Contracts;

public interface ITrendingPlantService
{
    Task<IEnumerable<Plant>> GetAllAsync(int pageNumber, int pageSize);
}