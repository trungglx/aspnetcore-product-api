using Microsoft.AspNetCore.Mvc;
using Moq;

namespace ProductApi.Controllers
{
    public class ProductControllerTests
    {
        private readonly Mock<IProductService> _mockService;
        private readonly ProductController _controller;

        public ProductControllerTests()
        {
            _mockService = new Mock<IProductService>();
            _controller = new ProductController(_mockService.Object);
        }

        [Fact]
        public async Task Get_ReturnsAllProducts()
        {
            // Arrange
            var products = new List<Product>
        {
            new Product { Id = 1, Name = "Banana", Price = 10000 }
        };
            _mockService.Setup(s => s.GetAllAsync()).ReturnsAsync(products);

            // Act
            var result = await _controller.Get();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnProducts = Assert.IsType<List<Product>>(okResult.Value);
            Assert.Single(returnProducts);
        }

        [Fact]
        public async Task GetById_ReturnsProduct_WhenExists()
        {
            var product = new Product { Id = 1, Name = "Grape", Price = 12000 };
            _mockService.Setup(s => s.GetByIdAsync(1)).ReturnsAsync(product);

            var result = await _controller.GetById(1);

            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnProduct = Assert.IsType<Product>(okResult.Value);
            Assert.Equal("Grape", returnProduct.Name);
        }

        [Fact]
        public async Task GetById_ReturnsNotFound_WhenNotExist()
        {
            _mockService.Setup(s => s.GetByIdAsync(99)).ReturnsAsync((Product?)null);

            var result = await _controller.GetById(99);

            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task Create_ReturnsCreatedProduct()
        {
            var input = new Product { Name = "Apple", Price = 13000 };
            var saved = new Product { Id = 1, Name = "Apple", Price = 13000 };

            _mockService.Setup(s => s.CreateAsync(input)).ReturnsAsync(saved);

            var result = await _controller.Create(input);

            var created = Assert.IsType<CreatedAtActionResult>(result);
            var returnProduct = Assert.IsType<Product>(created.Value);
            Assert.Equal("Apple", returnProduct.Name);
        }

        [Fact]
        public async Task Update_ReturnsOk_WhenProductExists()
        {
            var updated = new Product { Id = 1, Name = "Mango", Price = 20000 };
            _mockService.Setup(s => s.UpdateAsync(1, updated)).ReturnsAsync(updated);

            var result = await _controller.Update(1, updated);

            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnProduct = Assert.IsType<Product>(okResult.Value);
            Assert.Equal("Mango", returnProduct.Name);
        }

        [Fact]
        public async Task Update_ReturnsNotFound_WhenNotExist()
        {
            var updated = new Product { Id = 99, Name = "Melon", Price = 15000 };
            _mockService.Setup(s => s.UpdateAsync(99, updated)).ReturnsAsync((Product?)null);

            var result = await _controller.Update(99, updated);

            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task Delete_ReturnsNoContent_WhenDeleted()
        {
            _mockService.Setup(s => s.DeleteAsync(1)).ReturnsAsync(true);

            var result = await _controller.Delete(1);

            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task Delete_ReturnsNotFound_WhenNotExist()
        {
            _mockService.Setup(s => s.DeleteAsync(99)).ReturnsAsync(false);

            var result = await _controller.Delete(99);

            Assert.IsType<NotFoundResult>(result);
        }
    }
}