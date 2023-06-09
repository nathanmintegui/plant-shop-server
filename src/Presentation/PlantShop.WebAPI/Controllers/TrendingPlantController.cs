using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlantShop.Application.Contracts;

namespace PlantShop.WebAPI.Controllers;

[ApiController]
[Route("v1/trending")]
public class TrendingPlantController : ControllerBase
{
    private readonly ITrendingPlantService _trendingPlantService;

    public TrendingPlantController(ITrendingPlantService trendingPlantService)
    {
        _trendingPlantService = trendingPlantService;
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> getAll([FromQuery] int pageNumber = 0, [FromQuery] int pageSize = 15)
    {
        var response = await _trendingPlantService.GetAllAsync(pageNumber, pageSize);

        return Ok(response);
    }
}