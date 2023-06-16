using PlantShop.Domain.Models;

namespace PlantShop.Domain.Repositories;

public interface IServiceRepository
{
    Task<IEnumerable<Services>> GetAllAsync(Pager pager);
}