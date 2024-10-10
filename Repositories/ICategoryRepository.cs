using ProductsOrdersAPI.Models;

namespace ProductsOrdersAPI.Repositories;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAll();
    Task<Category> GetById(int id);
    Task Create(Category category);
    Task Update(Category category);
    Task Delete(int id);
}
