using Xunit;
using ProductApi.Services;
using ProductApi.Models;
using System.Linq;

namespace ProductApi.Tests.Services
{
    public class CategoryServiceTests
    {
        private readonly CategoryService _service;

        public CategoryServiceTests()
        {
            _service = new CategoryService();
        }

        [Fact]
        public void GetAll_ShouldReturnInitialCategories()
        {
            // Act
            var result = _service.GetAll();

            // Assert
            Assert.NotEmpty(result);
            Assert.Equal(2, result.Count()); // Vì khởi tạo sẵn 2 category
        }

        [Fact]
        public void GetById_ShouldReturnCorrectCategory()
        {
            var category = _service.GetById(1);

            Assert.NotNull(category);
            Assert.Equal("Fruits", category.Name);
        }

        [Fact]
        public void Add_ShouldIncreaseCategoryCount()
        {
            var newCat = new Category { Id = 3, Name = "Nuts", Description = "Healthy" };

            _service.Add(newCat);
            var result = _service.GetAll();

            Assert.Equal(3, result.Count());
            Assert.Contains(result, c => c.Id == 3);
        }

        [Fact]
        public void Update_ShouldModifyExistingCategory()
        {
            var update = new Category { Id = 1, Name = "Updated", Description = "Changed" };

            _service.Update(update);
            var updatedCat = _service.GetById(1);

            Assert.Equal("Updated", updatedCat.Name);
        }

        [Fact]
        public void Delete_ShouldRemoveCategory()
        {
            _service.Delete(1);
            var result = _service.GetAll();

            Assert.DoesNotContain(result, c => c.Id == 1);
        }
    }
}
