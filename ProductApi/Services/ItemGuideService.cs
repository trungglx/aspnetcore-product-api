using ProductApi.Repositories;
using ProductApi.Data;
namespace ProductApi.Services;
public class ItemGuideService : IItemGuideService
{
    private readonly IItemGuideRepository _repo;
    public ItemGuideService(IItemGuideRepository repo) => _repo = repo;
    public Task<IEnumerable<GuideItem>> GetItemsAsync(string? s = null) => _repo.GetAllAsync(s);
    public Task<GuideItem?> GetItemAsync(int id) => _repo.GetByIdAsync(id);
    public Task<GuideItem> CreateAsync(GuideItem entity) => _repo.AddAsync(entity);
    public Task<GuideItem> UpdateAsync(GuideItem entity) => _repo.UpdateAsync(entity);
    public Task DeleteAsync(int id) => _repo.DeleteAsync(id);
}
