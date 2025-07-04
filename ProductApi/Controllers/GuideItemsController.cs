using Microsoft.AspNetCore.Mvc;
using ProductApi.Services;
using ProductApi.Data;
using ProductApi.Dtos;
namespace ProductApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class GuideItemsController : ControllerBase
{
    private readonly IItemGuideService _svc;
    public GuideItemsController(IItemGuideService svc) => _svc = svc;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<GuideItemDto>>> Get([FromQuery] string? search)
    {
        var items = await _svc.GetItemsAsync(search);
        var dto = items.Select(i => new GuideItemDto(i.Id, i.Name, i.TypeId, i.Level, i.Options, i.ImageUrl, i.Description));
        return Ok(dto);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GuideItemDto>> Get(int id)
    {
        var item = await _svc.GetItemAsync(id);
        if (item == null) return NotFound();
        return new GuideItemDto(item.Id, item.Name, item.TypeId, item.Level, item.Options, item.ImageUrl, item.Description);
    } 
}