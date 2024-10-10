using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductsOrdersAPI.Migrations
{
    /// <inheritdoc />
    public partial class CategorySeeders2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "Productos relacionados con tecnología y dispositivos electrónicos.", "Electrónica" },
                    { 2, "Artículos para la casa, desde muebles hasta decoración.", "Hogar" },
                    { 3, "Ropa y accesorios de última tendencia.", "Moda" },
                    { 4, "Equipamiento y ropa para diversas actividades deportivas.", "Deportes" },
                    { 5, "Productos de cuidado personal y bienestar.", "Salud y Belleza" },
                    { 6, "Juguetes y juegos para niños de todas las edades.", "Juguetes" },
                    { 7, "Accesorios y piezas para vehículos.", "Automotriz" },
                    { 8, "Comida y bebidas de diversas culturas.", "Alimentos y Bebidas" },
                    { 9, "Literatura y libros de texto en diferentes géneros.", "Libros" },
                    { 10, "Herramientas y productos para el cuidado del jardín.", "Jardinería" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "id",
                keyValue: 10);
        }
    }
}
