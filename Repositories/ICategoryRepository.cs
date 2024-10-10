using ProductsOrdersAPI.Models;

namespace ProductsOrdersAPI.Repositories;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAllCategories();
    Task<Category> GetCategoryById(int id);
    Task CreateCategory(Category category);
    Task UpdateCategory(Category category);
    Task DeleteCategory(int id);
}
