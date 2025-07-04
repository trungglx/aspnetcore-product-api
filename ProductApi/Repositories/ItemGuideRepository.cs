using Microsoft.EntityFrameworkCore;
using ProductApi.Data;
namespace ProductApi.Repositories;
public class ItemGuideRepository : IItemGuideRepository
{
    private readonly ItemGuideContext _db;
    public ItemGuideRepository(ItemGuideContext db) => _db = db;

    public async Task<IEnumerable<GuideItem>> GetAllAsync(string? search = null)
    {
        var q = _db.Items.AsQueryable();
        if (!string.IsNullOrWhiteSpace(search))
            q = q.Where(i => i.Name.Contains(search));
        return await q.AsNoTracking()
                      .Include(i => i.Type)
                      .Select(i => new GuideItem
                      {
                          Id = i.Id,
                          Name = i.Name,
                          Description = i.Description // Removed TypeId as GuideItem does not have this property
                      })
                      .ToListAsync();
    }

    public async Task<GuideItem?> GetByIdAsync(int id) => await _db.Items
        .Include(i => i.ItemOptions)
        .Select(i => new GuideItem
        {
            Id = i.Id,
            Name = i.Name,
            Description = i.Description // Removed TypeId as GuideItem does not have this property
        })
        .FirstOrDefaultAsync(i => i.Id == id);

    public async Task<GuideItem> AddAsync(GuideItem entity)
    {
        var item = new Item
        {
            Id = entity.Id,
            Name = entity.Name,
            Description = entity.Description // Removed TypeId as GuideItem does not have this property
        };
        _db.Items.Add(item);
        await _db.SaveChangesAsync();
        return entity;
    }

    public async Task<GuideItem> UpdateAsync(GuideItem entity)
    {
        var item = new Item
        {
            Id = entity.Id,
            Name = entity.Name,
            Description = entity.Description // Removed TypeId as GuideItem does not have this property
        };
        _db.Items.Update(item);
        await _db.SaveChangesAsync();
        return entity;
    }

    public async Task DeleteAsync(int id)
    {
        var e = await _db.Items.FindAsync(id);
        if (e == null) return;
        _db.Items.Remove(e);
        await _db.SaveChangesAsync();
    }
}