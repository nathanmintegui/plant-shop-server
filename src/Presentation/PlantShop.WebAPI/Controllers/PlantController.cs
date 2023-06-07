using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlantShop.Application.Contracts;

namespace PlantShop.WebAPI.Controllers;

[ApiController]
[Route("v1/plants")]
public class PlantController : ControllerBase
{
    private readonly IPlantService _plantService;

    public PlantController(IPlantService plantService)
    {
        _plantService = plantService;
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> getAllPlants([FromQuery] int pageNumber = 0, [FromQuery] int pageSize = 15)
    {
        var response = await _plantService.GetAllAsync(pageNumber, pageSize);

        return Ok(response);
    }
}