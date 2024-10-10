using Microsoft.EntityFrameworkCore;
using ProductsOrdersAPI.Models;

namespace ProductsOrdersAPI.Seeders;

public class CategorySeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Electrónica", Description = "Productos relacionados con tecnología y dispositivos electrónicos." },
            new Category { Id = 2, Name = "Hogar", Description = "Artículos para la casa, desde muebles hasta decoración." },
            new Category { Id = 3, Name = "Moda", Description = "Ropa y accesorios de última tendencia." },
            new Category { Id = 4, Name = "Deportes", Description = "Equipamiento y ropa para diversas actividades deportivas." },
            new Category { Id = 5, Name = "Salud y Belleza", Description = "Productos de cuidado personal y bienestar." },
            new Category { Id = 6, Name = "Juguetes", Description = "Juguetes y juegos para niños de todas las edades." },
            new Category { Id = 7, Name = "Automotriz", Description = "Accesorios y piezas para vehículos." },
            new Category { Id = 8, Name = "Alimentos y Bebidas", Description = "Comida y bebidas de diversas culturas." },
            new Category { Id = 9, Name = "Libros", Description = "Literatura y libros de texto en diferentes géneros." },
            new Category { Id = 10, Name = "Jardinería", Description = "Herramientas y productos para el cuidado del jardín." }
        );
    }
}
