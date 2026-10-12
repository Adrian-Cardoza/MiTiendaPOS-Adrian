using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiTiendaPOS.Migrations
{
    /// <inheritdoc />
    public partial class DatosPrueba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Correo", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, null, "Consumidor final", "5555-5678" },
                    { 2, "maria@example.com", "María López", "5555-1234" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Activo", "CategoriaId", "Nombre", "PrecioUnitario", "Stock" },
                values: new object[,]
                {
                    { 1, false, 1, "Laptop", 1000.00m, 0 },
                    { 2, false, 2, "Camiseta", 20.00m, 0 },
                    { 3, false, 3, "Manzanas", 2.00m, 0 },
                    { 4, false, 1, "Teléfono", 500.00m, 0 },
                    { 5, false, 2, "Pantalones", 40.00m, 0 },
                    { 6, false, 3, "Pan", 1.50m, 0 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "NombreUsuario", "Rol" },
                values: new object[] { 2, "cajero1", "Cajero" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
