using PlantShop.Domain.Models;

namespace PlantShop.Application.Contracts;

public interface IPlanterService
{
    Task<IEnumerable<Planter>> GetAllAsync(int pageNumber, int pageSize);
}