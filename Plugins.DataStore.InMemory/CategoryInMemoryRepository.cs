using CoreBusiness;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;

        public CategoryInMemoryRepository()
        {
                categories = new List<Category>()
                {
                    new Category{CategoryId = 1,Name = "Beverage", Description="Beverage" },
                    new Category{CategoryId = 2,Name = "Pastries", Description="Pastries" },
                    new Category{CategoryId = 3,Name = "Meat", Description="Meat" }
                };
        }

        public void AddCategory(Category category)
        {
            if (categories.Any(c => c.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;
            if(categories != null && categories.Count > 0)
            {
                var maxId = categories.Max(c => c.CategoryId);
                category.CategoryId = maxId + 1;
            }
            else
            {
                category.CategoryId = 1;
            }
       
            categories.Add(category);
        }

        public void DeleteCategory(int categoryId)
        {
            var category = GetCategoryById(categoryId);
            categories.Remove(category);
         }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int categoryId)
        {
            var category = categories.FirstOrDefault(c=> c.CategoryId == categoryId);
            if (category != null)
                return category;
            else return null;
        }

        public void UpdateCategory(Category newCategory)
        {
            var category = GetCategoryById(newCategory.CategoryId);
                //categories.Find(c => c.CategoryId == newCategory.CategoryId && c.Name == newCategory.Name);
            if (category != null) 
            { 
                category.Name = newCategory.Name;
                category.Description = newCategory.Description;
            }
        }
    }
}