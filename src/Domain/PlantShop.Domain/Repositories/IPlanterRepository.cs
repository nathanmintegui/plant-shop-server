using PlantShop.Domain.Models;

namespace PlantShop.Domain.Repositories;

public interface IPlanterRepository
{
    Task<IEnumerable<Planter>> GetAllAsync(int pageNumber, int pageSize);
}