using PlantShop.Application.Contracts;
using PlantShop.Domain.Models;
using PlantShop.Domain.Repositories;

namespace PlantShop.Application.Implementations.Services;

public class PlanterService : IPlanterService
{
    private readonly IPlanterRepository _planterRepository;

    public PlanterService(IPlanterRepository planterRepository)
    {
        _planterRepository = planterRepository;
    }

    public async Task<IEnumerable<Planter>> GetAllAsync(int pageNumber, int pageSize)
    {
        var pager = new Pager(pageNumber, pageSize);

        var response = await _planterRepository.GetAllAsync(pager);

        return response;
    }
}