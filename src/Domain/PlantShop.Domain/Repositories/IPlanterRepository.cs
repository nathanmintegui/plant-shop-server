using PlantShop.Domain.Models;

namespace PlantShop.Domain.Repositories;

public interface IPlanterRepository
{
    Task<IEnumerable<Planter>> GetAllAsync(Pager pager);
}