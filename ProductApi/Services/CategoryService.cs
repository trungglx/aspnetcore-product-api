using ProductApi.Models;

namespace ProductApi.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly List<Category> _categories = new()
        {
            new Category { Id = 1, Name = "Fruits", Description = "All types of fruits" },
            new Category { Id = 2, Name = "Vegetables", Description = "Fresh vegetables" }
        };

        public IEnumerable<Category> GetAll() => _categories;

        public Category GetById(int id) => _categories.FirstOrDefault(c => c.Id == id);

        public void Add(Category category) => _categories.Add(category);

        public void Update(Category category)
        {
            var index = _categories.FindIndex(c => c.Id == category.Id);
            if (index != -1)
                _categories[index] = category;
        }

        public void Delete(int id)
        {
            var category = GetById(id);
            if (category != null) _categories.Remove(category);
        }
    }
}
