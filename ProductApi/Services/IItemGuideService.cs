using ProductApi.Data;
namespace ProductApi.Services;
public interface IItemGuideService
{
    Task<IEnumerable<GuideItem>> GetItemsAsync(string? search = null);
    Task<GuideItem?> GetItemAsync(int id);
    Task<GuideItem> CreateAsync(GuideItem entity);
    Task<GuideItem> UpdateAsync(GuideItem entity);
    Task DeleteAsync(int id);
}