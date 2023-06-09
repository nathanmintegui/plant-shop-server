using PlantShop.Application.Contracts;
using PlantShop.Domain.Models;
using PlantShop.Domain.Repositories;

public class ServicesService : IServicesService
{
    private readonly IServiceRepository _serviceRepository;

    public ServicesService(IServiceRepository serviceRepository)
    {
        _serviceRepository = serviceRepository;
    }

    public async Task<IEnumerable<Services>> GetAllAsync(int pageNumber, int pageSize)
    {
        var response = await _serviceRepository.GetAllAsync(pageNumber, pageSize);

        return response;
    }
}