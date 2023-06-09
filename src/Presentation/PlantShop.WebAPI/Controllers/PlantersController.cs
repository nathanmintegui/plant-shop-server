using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlantShop.Application.Contracts;

namespace PlantShop.WebAPI.Controllers;

[ApiController]
[Route("v1/planters")]
public class PlantersController : ControllerBase
{
    private readonly IPlanterService _planterService;

    public PlantersController(IPlanterService planterService)
    {
        _planterService = planterService;
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> getAll([FromQuery] int pageNumber = 0, [FromQuery] int pageSize = 15)
    {
        var response = await _planterService.GetAllAsync(pageNumber, pageSize);

        return Ok(response);
    }
}