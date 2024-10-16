using Microsoft.AspNetCore.Mvc;
using ProductsOrdersAPI.Repositories;
using ProductsOrdersAPI.Models;
using ProductsOrdersAPI.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace ProductsOrdersAPI.Controllers.V1.Categories;

[ApiController]
[Route("api/v1/categories")]
[Tags("Categories")]
public class CategoriesCreateController : CategoriesController
{
    public CategoriesCreateController(ICategoryRepository categoryRepository) : base(categoryRepository) { }

    // POST: api/v1/categories
    [HttpPost]
    [SwaggerOperation(
        Summary = "Create a new category",
        Description = "Adds a new category to the system"
    )]
    public async Task<IActionResult> CreateCategory([FromBody] CategoryDTO categoryDto)
    {
        if (categoryDto == null)
        {
            return BadRequest("Category data is required.");
        }

        try
        {
            // Map DTO to the Category model
            var category = new Category
            {
                Name = categoryDto.Name,
                Description = categoryDto.Description
            };

            await _categoryRepository.Create(category);
            return Ok("Category created successfully");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}
