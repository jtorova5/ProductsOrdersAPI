using System.ComponentModel.DataAnnotations;

namespace ProductsOrdersAPI.DTOs;

public class CategoryDTO
{
    [Required(ErrorMessage = "Name is required")]
    [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
    public required string Name { get; set; }

    [MaxLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
    public string? Description { get; set; }
}
