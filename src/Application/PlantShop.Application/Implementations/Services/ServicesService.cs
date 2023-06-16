using PlantShop.Application.Contracts;
using PlantShop.Domain.Models;
using PlantShop.Domain.Repositories;

namespace PlantShop.Application.Implementations.Services;

public class ServicesService : IServicesService
{
    private readonly IServiceRepository _serviceRepository;

    public ServicesService(IServiceRepository serviceRepository)
    {
        _serviceRepository = serviceRepository;
    }

    public async Task<IEnumerable<Domain.Models.Services>> GetAllAsync(int pageNumber, int pageSize)
    {
        var pager = new Pager(pageNumber, pageSize);

        var response = await _serviceRepository.GetAllAsync(pager);

        return response;
    }
}