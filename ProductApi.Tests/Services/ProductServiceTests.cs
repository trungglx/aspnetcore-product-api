using Moq;

public class ProductServiceTests
{
    private readonly Mock<IProductRepository> _mockRepo;
    private readonly ProductService _service;

    public ProductServiceTests()
    {
        _mockRepo = new Mock<IProductRepository>();
        _service = new ProductService(_mockRepo.Object);
    }

    [Fact]
    public async Task GetAllAsync_ReturnsAllProducts()
    {
        // Arrange
        var products = new List<Product> {
            new Product { Id = 1, Name = "Táo", Price = 20000 },
            new Product { Id = 2, Name = "Nho", Price = 30000 }
        };
        _mockRepo.Setup(r => r.GetAllAsync()).ReturnsAsync(products);

        // Act
        var result = await _service.GetAllAsync();

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Equal("Táo", result[0].Name);
    }

    [Fact]
    public async Task GetByIdAsync_ReturnsProduct_IfExists()
    {
        // Arrange
        var product = new Product { Id = 1, Name = "Mít", Price = 15000 };
        _mockRepo.Setup(r => r.GetByIdAsync(1)).ReturnsAsync(product);

        // Act
        var result = await _service.GetByIdAsync(1);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("Mít", result.Name);
    }

    [Fact]
    public async Task CreateAsync_AddsProduct()
    {
        // Arrange
        var newProduct = new Product { Name = "Cam", Price = 22000 };

        // Act
        var result = await _service.CreateAsync(newProduct);

        // Assert
        _mockRepo.Verify(r => r.AddAsync(newProduct), Times.Once);
        Assert.Equal("Cam", result.Name);
    }

    [Fact]
    public async Task UpdateAsync_ReturnsNull_IfNotFound()
    {
        // Arrange
        _mockRepo.Setup(r => r.GetByIdAsync(1)).ReturnsAsync((Product)null!);

        // Act
        var result = await _service.UpdateAsync(1, new Product());

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public async Task DeleteAsync_ReturnsFalse_IfNotFound()
    {
        // Arrange
        _mockRepo.Setup(r => r.GetByIdAsync(1)).ReturnsAsync((Product)null!);

        // Act
        var result = await _service.DeleteAsync(1);

        // Assert
        Assert.False(result);
    }
}
