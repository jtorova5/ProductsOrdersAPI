using Microsoft.EntityFrameworkCore;
using ProductsOrdersAPI.Models;

namespace ProductsOrdersAPI.Seeders;

public class ProductSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "smartphone", Description = "teléfono inteligente con pantalla táctil.", Price = 299.99, Stock = 50, CategoryId = 1 },
            new Product { Id = 2, Name = "laptop", Description = "portátil con alto rendimiento para trabajo y juego.", Price = 899.99, Stock = 30, CategoryId = 1 },
            new Product { Id = 3, Name = "televisor 4k", Description = "televisor con resolución 4k para una experiencia visual impresionante.", Price = 499.99, Stock = 20, CategoryId = 1 },
            new Product { Id = 4, Name = "sofá", Description = "sofá de tres plazas, cómodo y elegante.", Price = 499.99, Stock = 15, CategoryId = 2 },
            new Product { Id = 5, Name = "mesa de comedor", Description = "mesa de madera para 6 personas.", Price = 299.99, Stock = 10, CategoryId = 2 },
            new Product { Id = 6, Name = "lámpara de mesa", Description = "lámpara de mesa moderna con luz led.", Price = 49.99, Stock = 40, CategoryId = 2 },
            new Product { Id = 7, Name = "bicicleta de montaña", Description = "bicicleta diseñada para senderos y montaña.", Price = 599.99, Stock = 25, CategoryId = 3 },
            new Product { Id = 8, Name = "zapatillas de correr", Description = "calzado deportivo ligero y cómodo.", Price = 89.99, Stock = 60, CategoryId = 3 },
            new Product { Id = 9, Name = "balón de fútbol", Description = "balón oficial de fútbol para jugar en el campo.", Price = 29.99, Stock = 100, CategoryId = 3 },
            new Product { Id = 10, Name = "crema hidratante", Description = "crema para el cuidado de la piel, ideal para todo tipo de piel.", Price = 19.99, Stock = 80, CategoryId = 4 },
            new Product { Id = 11, Name = "champú", Description = "champú para un cabello sano y brillante.", Price = 15.99, Stock = 90, CategoryId = 4 },
            new Product { Id = 12, Name = "juguete de construcción", Description = "juguete para construir diferentes formas y estructuras.", Price = 34.99, Stock = 50, CategoryId = 5 },
            new Product { Id = 13, Name = "muñeca de trapo", Description = "muñeca hecha a mano, suave y amigable.", Price = 25.99, Stock = 45, CategoryId = 5 },
            new Product { Id = 14, Name = "auto de control remoto", Description = "auto a control remoto, ideal para niños.", Price = 49.99, Stock = 35, CategoryId = 5 },
            new Product { Id = 15, Name = "kit de herramientas", Description = "kit completo para reparación y mantenimiento del hogar.", Price = 79.99, Stock = 20, CategoryId = 6 },
            new Product { Id = 16, Name = "silla de oficina", Description = "silla ergonómica para oficina, ajustable.", Price = 129.99, Stock = 10, CategoryId = 6 },
            new Product { Id = 17, Name = "funda de sillón", Description = "funda para sillón, fácil de lavar.", Price = 39.99, Stock = 60, CategoryId = 6 },
            new Product { Id = 18, Name = "cerveza artesanal", Description = "cerveza elaborada de manera artesanal.", Price = 2.99, Stock = 200, CategoryId = 7 },
            new Product { Id = 19, Name = "café orgánico", Description = "café de alta calidad, 100% orgánico.", Price = 12.99, Stock = 150, CategoryId = 7 },
            new Product { Id = 20, Name = "chocolate gourmet", Description = "chocolate de alta calidad con sabores exóticos.", Price = 4.99, Stock = 300, CategoryId = 7 },
            new Product { Id = 21, Name = "novela clásica", Description = "una obra literaria clásica de la literatura.", Price = 14.99, Stock = 80, CategoryId = 8 },
            new Product { Id = 22, Name = "libro de cocina", Description = "recetario con deliciosas recetas.", Price = 19.99, Stock = 60, CategoryId = 8 },
            new Product { Id = 23, Name = "guía de viaje", Description = "guía completa para visitar diferentes destinos.", Price = 24.99, Stock = 40, CategoryId = 8 },
            new Product { Id = 24, Name = "maceta de cerámica", Description = "maceta decorativa para plantas.", Price = 9.99, Stock = 100, CategoryId = 9 },
            new Product { Id = 25, Name = "tijeras de jardín", Description = "tijeras para podar y cuidar plantas.", Price = 19.99, Stock = 80, CategoryId = 9 },
            new Product { Id = 26, Name = "guantes de jardinería", Description = "guantes resistentes para trabajar en el jardín.", Price = 14.99, Stock = 90, CategoryId = 9 },
            new Product { Id = 27, Name = "cuchillo de cocina", Description = "cuchillo de chef de alta calidad.", Price = 39.99, Stock = 40, CategoryId = 10 },
            new Product { Id = 28, Name = "sartén antiadherente", Description = "sartén de alta calidad para cocinar sin que se pegue.", Price = 29.99, Stock = 50, CategoryId = 10 },
            new Product { Id = 29, Name = "cuchara de madera", Description = "cuchara ecológica de madera.", Price = 4.99, Stock = 100, CategoryId = 10 },
            new Product { Id = 30, Name = "batidora de mano", Description = "batidora compacta y fácil de usar.", Price = 49.99, Stock = 30, CategoryId = 10 }
        );
    }
}
