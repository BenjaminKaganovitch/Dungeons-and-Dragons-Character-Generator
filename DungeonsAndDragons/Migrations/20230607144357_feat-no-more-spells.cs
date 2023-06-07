using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DungeonsAndDragons.Migrations
{
    /// <inheritdoc />
    public partial class featnomorespells : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Spell_Feat_FeatId",
                table: "Spell");

            migrationBuilder.DropIndex(
                name: "IX_Spell_FeatId",
                table: "Spell");

            migrationBuilder.DropColumn(
                name: "FeatId",
                table: "Spell");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Lineage");

            migrationBuilder.DropColumn(
                name: "MagicSchools",
                table: "Feat");

            migrationBuilder.AddColumn<string>(
                name: "MovementSpeed",
                table: "Sublineage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SubclassUnlockLevel",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovementSpeed",
                table: "Sublineage");

            migrationBuilder.DropColumn(
                name: "SubclassUnlockLevel",
                table: "Classes");

            migrationBuilder.AddColumn<int>(
                name: "FeatId",
                table: "Spell",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Lineage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MagicSchools",
                table: "Feat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Spell_FeatId",
                table: "Spell",
                column: "FeatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Spell_Feat_FeatId",
                table: "Spell",
                column: "FeatId",
                principalTable: "Feat",
                principalColumn: "Id");
        }
    }
}
