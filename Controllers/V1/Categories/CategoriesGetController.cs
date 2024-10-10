using Microsoft.AspNetCore.Mvc;
using ProductsOrdersAPI.Repositories;
using ProductsOrdersAPI.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace ProductsOrdersAPI.Controllers.V1.Categories;

[ApiController]
[Route("api/v1/categories")]
[Tags("Categories")]
public class CategoriesGetController : CategoriesController
{
    public CategoriesGetController(ICategoryRepository categoryRepository) : base(categoryRepository) { }

    // GET: api/v1/categories
    [HttpGet]
    [SwaggerOperation(
        Summary = "Retrieve all categories",
        Description = "Fetches a list of all categories in the system"
    )]
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
    [SwaggerOperation(
        Summary = "Retrieve a category by ID",
        Description = "Fetches a specific category from the system by its ID"
    )]
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
