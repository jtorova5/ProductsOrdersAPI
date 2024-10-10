using Microsoft.AspNetCore.Mvc;
using ProductsOrdersAPI.Repositories;
using ProductsOrdersAPI.Models;

namespace ProductsOrdersAPI.Controllers.V1.Categories;

[ApiController]
[Route("api/v1/categories")]
public class CategoriesGetController : CategoriesController
{
    public CategoriesGetController(ICategoryRepository categoryRepository) : base(categoryRepository) { }

    // GET: api/v1/categories
    [HttpGet]
    public async Task<IActionResult> GetAllCategories()
    {
        try
        {
            var categories = await _categoryRepository.GetAll();
            return Ok(categories);
        }
        catch (InvalidOperationException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    // GET: api/v1/categories/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetCategoryById(int id)
    {
        try
        {
            var category = await _categoryRepository.GetById(id);
            return Ok(category);
        }
        catch (ArgumentNullException)
        {
            return NotFound($"Category with id {id} not found.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}
