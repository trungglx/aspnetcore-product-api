using Microsoft.AspNetCore.Mvc;
using ProductApi.Data;
using ProductApi.Services;

namespace ProductApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GuideItemsController : ControllerBase
{
    private readonly IItemGuideService _service;
    public GuideItemsController(IItemGuideService service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] string? search = null)
    {
        var items = await _service.GetItemsAsync(search);
        return Ok(items);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var item = await _service.GetItemAsync(id);
        return item is null ? NotFound() : Ok(item);
    }

    [HttpPost]
    public async Task<IActionResult> Create(GuideItem dto)
    {
        var item = await _service.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, GuideItem dto)
    {
        if (id != dto.Id) return BadRequest();
        var existing = await _service.GetItemAsync(id);
        if (existing is null) return NotFound();
        var updated = await _service.UpdateAsync(dto);
        return Ok(updated);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var existing = await _service.GetItemAsync(id);
        if (existing is null) return NotFound();
        await _service.DeleteAsync(id);
        return NoContent();
    }
}
