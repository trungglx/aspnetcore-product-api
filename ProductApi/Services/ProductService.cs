public class ProductService : IProductService
{
    private readonly IProductRepository _repo;

    public ProductService(IProductRepository repo)
    {
        _repo = repo;
    }

    public async Task<List<Product>> GetAllAsync() => await _repo.GetAllAsync();

    public async Task<Product?> GetByIdAsync(int id) => await _repo.GetByIdAsync(id);

    public async Task<Product> CreateAsync(Product product)
    {
        await _repo.AddAsync(product);
        return product;
    }

    public async Task<Product?> UpdateAsync(int id, Product product)
    {
        var existing = await _repo.GetByIdAsync(id);
        if (existing == null) return null;

        existing.Name = product.Name;
        existing.Price = product.Price;

        await _repo.UpdateAsync(existing);
        return existing;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var product = await _repo.GetByIdAsync(id);
        if (product == null) return false;

        await _repo.DeleteAsync(product);
        return true;
    }
}
