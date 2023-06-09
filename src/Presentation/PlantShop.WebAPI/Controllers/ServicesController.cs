using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlantShop.Application.Contracts;

namespace PlantShop.WebAPI.Controllers;

[ApiController]
[Route("v1/services")]
public class ServicesController : ControllerBase
{
    private readonly IServicesService _servicesService;

    public ServicesController(IServicesService servicesService)
    {
        _servicesService = servicesService;
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> getAll([FromQuery] int pageNumber = 0, [FromQuery] int pageSize = 15)
    {
        var response = await _servicesService.GetAllAsync(pageNumber, pageSize);

        return Ok(response);
    }
}