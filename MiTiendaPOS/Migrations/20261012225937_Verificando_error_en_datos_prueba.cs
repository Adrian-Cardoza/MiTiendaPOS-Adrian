using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiTiendaPOS.Migrations
{
    /// <inheritdoc />
    public partial class Verificando_error_en_datos_prueba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "Bebidas");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nombre",
                value: "Abarrotes");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nombre",
                value: "Limpieza");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Activo", "Nombre", "PrecioUnitario", "Stock" },
                values: new object[] { true, "Soda 600ml", 0.90m, 48 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Activo", "CategoriaId", "Nombre", "PrecioUnitario", "Stock" },
                values: new object[] { true, 1, "Agua Purificada", 0.50m, 60 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Activo", "CategoriaId", "Nombre", "PrecioUnitario", "Stock" },
                values: new object[] { true, 2, "Arroz Blanco", 0.85m, 40 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Activo", "CategoriaId", "Nombre", "PrecioUnitario", "Stock" },
                values: new object[] { true, 2, "Frijol de Seda", 1.10m, 20 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Activo", "CategoriaId", "Nombre", "PrecioUnitario", "Stock" },
                values: new object[] { true, 3, "Detergente MAXI ESPUMA", 3.25m, 15 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Activo", "Nombre", "PrecioUnitario", "Stock" },
                values: new object[] { true, "Lejia 1L", 1.15m, 25 });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NombreUsuario", "Rol" },
                values: new object[] { "amin", "Administrador" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nombre",
                value: "Electrónica");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nombre",
                value: "Ropa");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nombre",
                value: "Alimentos");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Activo", "Nombre", "PrecioUnitario", "Stock" },
                values: new object[] { false, "Laptop", 1000.00m, 0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Activo", "CategoriaId", "Nombre", "PrecioUnitario", "Stock" },
                values: new object[] { false, 2, "Camiseta", 20.00m, 0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Activo", "CategoriaId", "Nombre", "PrecioUnitario", "Stock" },
                values: new object[] { false, 3, "Manzanas", 2.00m, 0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Activo", "CategoriaId", "Nombre", "PrecioUnitario", "Stock" },
                values: new object[] { false, 1, "Teléfono", 500.00m, 0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Activo", "CategoriaId", "Nombre", "PrecioUnitario", "Stock" },
                values: new object[] { false, 2, "Pantalones", 40.00m, 0 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Activo", "Nombre", "PrecioUnitario", "Stock" },
                values: new object[] { false, "Pan", 1.50m, 0 });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NombreUsuario", "Rol" },
                values: new object[] { "Admin", "Admin" });
        }
    }
}
