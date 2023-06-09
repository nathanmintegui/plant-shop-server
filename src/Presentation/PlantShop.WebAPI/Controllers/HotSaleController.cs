using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlantShop.Application.Contracts;

namespace PlantShop.WebAPI.Controllers;

[ApiController]
[Route("v1/hot-sales")]
public class HotSaleController : ControllerBase
{
    private readonly IPlantService _plantService;

    public HotSaleController(IPlantService plantService)
    {
        _plantService = plantService;
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> getAll([FromQuery] int pageNumber = 0, [FromQuery] int pageSize = 15)
    {
        var response = await _plantService.GetAllHotSaleAsync(pageNumber, pageSize);

        return Ok(response);
    }
}