using ProductApi.Data;
namespace ProductApi.Repositories;
public interface IItemGuideRepository
{
    Task<IEnumerable<GuideItem>> GetAllAsync(string? search = null);
    Task<GuideItem?>             GetByIdAsync(int id);
    Task<GuideItem>              AddAsync(GuideItem entity);
    Task<GuideItem>              UpdateAsync(GuideItem entity);
    Task                         DeleteAsync(int id);
}