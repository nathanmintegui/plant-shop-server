using PlantShop.Domain.Models;

namespace PlantShop.Application.Contracts;

public interface IPlantService
{
    Task<IEnumerable<Plant>> GetAllAsync(int pageNumber, int pageSize);
    Task<IEnumerable<Plant>> GetAllHotSaleAsync(int pageNumber, int pageSize);
}