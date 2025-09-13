using Microsoft.AspNetCore.Mvc;
using Moq;
using ProductApi.Controllers;
using ProductApi.Models;
using ProductApi.Services;

namespace ProductApi.Tests.Controllers
{
    public class CategoryControllerTests
    {
        private readonly Mock<ICategoryService> _mockService;
        private readonly CategoryController _controller;

        public CategoryControllerTests()
        {
            _mockService = new Mock<ICategoryService>();
            _controller = new CategoryController(_mockService.Object);
        }

        [Fact]
        public void GetAll_ReturnsOkResult_WithListOfCategories()
        {
            // Arrange
            var mockCategories = new List<Category>
            {
                new Category { Id = 1, Name = "Fruit", Description = "Fresh fruit" },
                new Category { Id = 2, Name = "Vegetable", Description = "Green veg" }
            };

            _mockService.Setup(s => s.GetAll()).Returns(mockCategories);

            // Act
            var result = _controller.GetAll();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnData = Assert.IsAssignableFrom<IEnumerable<Category>>(okResult.Value);
            Assert.Equal(2, (returnData as List<Category>).Count);
        }

        [Fact]
        public void GetById_ExistingId_ReturnsOkResult()
        {
            var category = new Category { Id = 1, Name = "Fruit", Description = "Sweet" };
            _mockService.Setup(s => s.GetById(1)).Returns(category);

            var result = _controller.GetById(1);

            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnCategory = Assert.IsType<Category>(okResult.Value);
            Assert.Equal("Fruit", returnCategory.Name);
        }

        [Fact]
        public void GetById_NotFound_ReturnsNotFound()
        {
            _mockService.Setup(s => s.GetById(999)).Returns((Category)null);

            var result = _controller.GetById(999);

            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void Add_ValidCategory_ReturnsCreatedResult()
        {
            var newCat = new Category { Id = 3, Name = "Dairy", Description = "Milk" };
            _mockService.Setup(s => s.Add(newCat));

            var result = _controller.Add(newCat);

            var createdResult = Assert.IsType<CreatedAtActionResult>(result);
            var returnCat = Assert.IsType<Category>(createdResult.Value);
            Assert.Equal("Dairy", returnCat.Name);
        }

        [Fact]
        public void Update_Valid_ReturnsOk()
        {
            var updatedCat = new Category { Id = 1, Name = "New Name", Description = "Updated" };
            _mockService.Setup(s => s.Update(updatedCat));

            var result = _controller.Update(updatedCat.Id, updatedCat);

            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnCat = Assert.IsType<Category>(okResult.Value);
            Assert.Equal("New Name", returnCat.Name);
        }

        [Fact]
        public void Delete_ValidId_ReturnsNoContent()
        {
            _mockService.Setup(s => s.Delete(1));

            var result = _controller.Delete(1);

            Assert.IsType<NoContentResult>(result);
        }

    }
}
