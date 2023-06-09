using PlantShop.Domain.Models;

namespace PlantShop.Application.Contracts;

public interface IServicesService
{
    Task<IEnumerable<Services>> GetAllAsync(int pageNumber, int pageSize);
}