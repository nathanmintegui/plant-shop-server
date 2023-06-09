using PlantShop.Application.Contracts;
using PlantShop.Domain.Models;
using PlantShop.Domain.Repositories;

namespace PlantShop.Application.Implementations.Services;

public class PlantService : IPlantService
{
    private readonly IPlantRepository _plantRepository;

    public PlantService(IPlantRepository plantRepository)
    {
        _plantRepository = plantRepository;
    }

    public async Task<IEnumerable<Plant>> GetAllAsync(int pageNumber, int pageSize)
    {
        var response = await _plantRepository.GetAllAsync(pageNumber, pageSize);

        return response;
    }

    public async Task<IEnumerable<Plant>> GetAllHotSaleAsync(int pageNumber, int pageSize)
    {
        var response = await _plantRepository.GetAllHotSaleAsync(pageNumber, pageSize);

        return response;
    }
}