using Microsoft.AspNetCore.Mvc;
using ProductsOrdersAPI.Repositories;
using ProductsOrdersAPI.Models;
using ProductsOrdersAPI.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace ProductsOrdersAPI.Controllers.V1.Categories;

[ApiController]
[Route("api/v1/categories")]
[Tags("Categories")]
public class CategoriesUpdateController : CategoriesController
{
    public CategoriesUpdateController(ICategoryRepository categoryRepository) : base(categoryRepository) { }

    // PUT: api/v1/categories/{id}
    [HttpPut("{id}")]
    [SwaggerOperation(
        Summary = "Update a category",
        Description = "Modifies an existing category in the system by its ID"
    )]
    public async Task<IActionResult> UpdateCategory(int id, [FromBody] CategoryDTO categoryDto)
    {
        if (categoryDto == null)
        {
            return BadRequest("Category data is required.");
        }

        try
        {
            var existingCategory = await _categoryRepository.GetById(id);
            if (existingCategory == null)
            {
                return NotFound($"Category with id {id} not found.");
            }

            // Map DTO to the existing category
            existingCategory.Name = categoryDto.Name;
            existingCategory.Description = categoryDto.Description;

            await _categoryRepository.Update(existingCategory);
            return Ok("Category updated successfully.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
}
