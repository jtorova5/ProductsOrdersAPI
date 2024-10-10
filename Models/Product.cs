using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsOrdersAPI.Models;

[Table("products")]
public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("name")]
    public required string Name { get; set; }

    [Required]
    [MaxLength(500)]
    [Column("description")]
    public required string Description { get; set; }

    [Required]
    [Column("price")]
    [Range(0.01, double.MaxValue)]
    public double Price { get; set; }

    [Required]
    [Column("stock")]
    [Range(0, int.MaxValue)]
    public int Stock { get; set; }

    [Required]
    [Column("category_id")]
    [ForeignKey("CategoryId")]
    public int CategoryId { get; set; }

    public Product(string name, string description, double price, int stock, int categoryId)
    {
        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        CategoryId = categoryId;
    }

    public Product() { }
}
