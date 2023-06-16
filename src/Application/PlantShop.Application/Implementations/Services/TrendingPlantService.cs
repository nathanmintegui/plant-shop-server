using PlantShop.Application.Contracts;
using PlantShop.Domain.Models;
using PlantShop.Domain.Repositories;

namespace PlantShop.Application.Implementations.Services;

public class TrendingPlantService : ITrendingPlantService
{
    private readonly ITrendingPlantRepository _trendingPlantRepository;

    public TrendingPlantService(ITrendingPlantRepository trendingPlantRepository)
    {
        _trendingPlantRepository = trendingPlantRepository;
    }

    public async Task<IEnumerable<Plant>> GetAllAsync(int pageNumber, int pageSize)
    {
        var pager = new Pager(pageNumber, pageSize);

        var response = await _trendingPlantRepository.GetAllAsync(pager);

        return response;
    }
}