using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bil_udlejning.Migrations
{
    /// <inheritdoc />
    public partial class CarAndController : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "base_price",
                table: "Cars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "base_price",
                table: "Cars");
        }
    }
}
