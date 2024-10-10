using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductsOrdersAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreatingProductTableAndSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "id", "category_id", "description", "name", "price", "stock" },
                values: new object[,]
                {
                    { 1, 1, "teléfono inteligente con pantalla táctil.", "smartphone", 299.99000000000001, 50 },
                    { 2, 1, "portátil con alto rendimiento para trabajo y juego.", "laptop", 899.99000000000001, 30 },
                    { 3, 1, "televisor con resolución 4k para una experiencia visual impresionante.", "televisor 4k", 499.99000000000001, 20 },
                    { 4, 2, "sofá de tres plazas, cómodo y elegante.", "sofá", 499.99000000000001, 15 },
                    { 5, 2, "mesa de madera para 6 personas.", "mesa de comedor", 299.99000000000001, 10 },
                    { 6, 2, "lámpara de mesa moderna con luz led.", "lámpara de mesa", 49.990000000000002, 40 },
                    { 7, 3, "bicicleta diseñada para senderos y montaña.", "bicicleta de montaña", 599.99000000000001, 25 },
                    { 8, 3, "calzado deportivo ligero y cómodo.", "zapatillas de correr", 89.989999999999995, 60 },
                    { 9, 3, "balón oficial de fútbol para jugar en el campo.", "balón de fútbol", 29.989999999999998, 100 },
                    { 10, 4, "crema para el cuidado de la piel, ideal para todo tipo de piel.", "crema hidratante", 19.989999999999998, 80 },
                    { 11, 4, "champú para un cabello sano y brillante.", "champú", 15.99, 90 },
                    { 12, 5, "juguete para construir diferentes formas y estructuras.", "juguete de construcción", 34.990000000000002, 50 },
                    { 13, 5, "muñeca hecha a mano, suave y amigable.", "muñeca de trapo", 25.989999999999998, 45 },
                    { 14, 5, "auto a control remoto, ideal para niños.", "auto de control remoto", 49.990000000000002, 35 },
                    { 15, 6, "kit completo para reparación y mantenimiento del hogar.", "kit de herramientas", 79.989999999999995, 20 },
                    { 16, 6, "silla ergonómica para oficina, ajustable.", "silla de oficina", 129.99000000000001, 10 },
                    { 17, 6, "funda para sillón, fácil de lavar.", "funda de sillón", 39.990000000000002, 60 },
                    { 18, 7, "cerveza elaborada de manera artesanal.", "cerveza artesanal", 2.9900000000000002, 200 },
                    { 19, 7, "café de alta calidad, 100% orgánico.", "café orgánico", 12.99, 150 },
                    { 20, 7, "chocolate de alta calidad con sabores exóticos.", "chocolate gourmet", 4.9900000000000002, 300 },
                    { 21, 8, "una obra literaria clásica de la literatura.", "novela clásica", 14.99, 80 },
                    { 22, 8, "recetario con deliciosas recetas.", "libro de cocina", 19.989999999999998, 60 },
                    { 23, 8, "guía completa para visitar diferentes destinos.", "guía de viaje", 24.989999999999998, 40 },
                    { 24, 9, "maceta decorativa para plantas.", "maceta de cerámica", 9.9900000000000002, 100 },
                    { 25, 9, "tijeras para podar y cuidar plantas.", "tijeras de jardín", 19.989999999999998, 80 },
                    { 26, 9, "guantes resistentes para trabajar en el jardín.", "guantes de jardinería", 14.99, 90 },
                    { 27, 10, "cuchillo de chef de alta calidad.", "cuchillo de cocina", 39.990000000000002, 40 },
                    { 28, 10, "sartén de alta calidad para cocinar sin que se pegue.", "sartén antiadherente", 29.989999999999998, 50 },
                    { 29, 10, "cuchara ecológica de madera.", "cuchara de madera", 4.9900000000000002, 100 },
                    { 30, 10, "batidora compacta y fácil de usar.", "batidora de mano", 49.990000000000002, 30 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "id",
                keyValue: 30);
        }
    }
}
