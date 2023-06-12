using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DungeonsAndDragons.Migrations
{
    /// <inheritdoc />
    public partial class ttttttttttgetnomobilethatmeansyoujohn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "AspNetUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
