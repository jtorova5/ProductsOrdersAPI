using Microsoft.EntityFrameworkCore;
using ProductsOrdersAPI.Data;
using ProductsOrdersAPI.Models;
using ProductsOrdersAPI.Repositories;

namespace ProductsOrdersAPI.Services;

public class CategoryServices : ICategoryRepository
{
    protected readonly AppDbContext _context;

    public CategoryServices(AppDbContext context)
    {
        _context = context;
    }

    public async Task Create(Category category)
    {
        if (category == null)
        {
            throw new ArgumentNullException(nameof(category), "Guest cannot be null");
        }
        try
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEx)
        {
            throw new Exception("Failed to add category into the database", dbEx);
        }
        catch (Exception ex)
        {
            throw new Exception("Unexpected error adding the category", ex);
        }
    }

    public async Task Delete(int id)
    {
        var category = await _context.Categories.FindAsync(id);
        if (category == null)
        {
            throw new ArgumentNullException(nameof(category), "Category not found");
        }
        else
        {
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Category>> GetAll()
    {
        if (!_context.Categories.Any())
        {
            throw new InvalidOperationException("No category found in the database");
        }
        return await _context.Categories.ToListAsync();
    }

    public async Task<Category> GetById(int id)
    {
        try
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category), "Category not found");
            }
            return category;
        }
        catch (Exception ex)
        {
            throw new Exception("Error retrieving the category", ex);
        }
    }

    public async Task Update(Category category)
    {
        if (category == null)
        {
            throw new ArgumentNullException(nameof(category), "Category cannot be null");
        }
        try
        {
            _context.Entry(category).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEx)
        {
            throw new Exception("Failed to update category in the database", dbEx);
        }
        catch (Exception ex)
        {
            throw new Exception("Unexpected error updating the category", ex);
        }
    }
}

