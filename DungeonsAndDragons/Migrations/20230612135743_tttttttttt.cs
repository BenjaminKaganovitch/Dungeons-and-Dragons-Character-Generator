using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DungeonsAndDragons.Migrations
{
    /// <inheritdoc />
    public partial class tttttttttt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Background_AspNetUsers_CreatorId",
                table: "Background");

            migrationBuilder.DropForeignKey(
                name: "FK_Background_Characters_CharacterId",
                table: "Background");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterClasses_Subclass_SubclassId",
                table: "CharacterClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Lineage_LineageId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Sublineage_SublineageId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Feat_AspNetUsers_CreatorId",
                table: "Feat");

            migrationBuilder.DropForeignKey(
                name: "FK_Feat_Characters_CharacterId",
                table: "Feat");

            migrationBuilder.DropForeignKey(
                name: "FK_Features_Background_BackgroundId",
                table: "Features");

            migrationBuilder.DropForeignKey(
                name: "FK_Features_Lineage_LineageId",
                table: "Features");

            migrationBuilder.DropForeignKey(
                name: "FK_Features_Subclass_SubclassId",
                table: "Features");

            migrationBuilder.DropForeignKey(
                name: "FK_Features_Sublineage_SublineageId",
                table: "Features");

            migrationBuilder.DropForeignKey(
                name: "FK_Lineage_AspNetUsers_CreatorId",
                table: "Lineage");

            migrationBuilder.DropForeignKey(
                name: "FK_Spell_AspNetUsers_CreatorId",
                table: "Spell");

            migrationBuilder.DropForeignKey(
                name: "FK_Spell_Characters_CharacterId",
                table: "Spell");

            migrationBuilder.DropForeignKey(
                name: "FK_Spell_Classes_ClassId",
                table: "Spell");

            migrationBuilder.DropForeignKey(
                name: "FK_Spell_Subclass_SubclassId",
                table: "Spell");

            migrationBuilder.DropForeignKey(
                name: "FK_Spell_Sublineage_SublineageId",
                table: "Spell");

            migrationBuilder.DropForeignKey(
                name: "FK_StatBoosts_Lineage_LineageId",
                table: "StatBoosts");

            migrationBuilder.DropForeignKey(
                name: "FK_StatBoosts_Sublineage_SublineageId",
                table: "StatBoosts");

            migrationBuilder.DropForeignKey(
                name: "FK_Subclass_AspNetUsers_CreatorId",
                table: "Subclass");

            migrationBuilder.DropForeignKey(
                name: "FK_Subclass_Classes_ClassId",
                table: "Subclass");

            migrationBuilder.DropForeignKey(
                name: "FK_Sublineage_AspNetUsers_CreatorId",
                table: "Sublineage");

            migrationBuilder.DropForeignKey(
                name: "FK_Sublineage_Lineage_LineageId",
                table: "Sublineage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sublineage",
                table: "Sublineage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subclass",
                table: "Subclass");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Spell",
                table: "Spell");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lineage",
                table: "Lineage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Feat",
                table: "Feat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Background",
                table: "Background");

            migrationBuilder.RenameTable(
                name: "Sublineage",
                newName: "Sublineages");

            migrationBuilder.RenameTable(
                name: "Subclass",
                newName: "Subclasses");

            migrationBuilder.RenameTable(
                name: "Spell",
                newName: "Spells");

            migrationBuilder.RenameTable(
                name: "Lineage",
                newName: "Lineages");

            migrationBuilder.RenameTable(
                name: "Feat",
                newName: "Feats");

            migrationBuilder.RenameTable(
                name: "Background",
                newName: "Backgrounds");

            migrationBuilder.RenameIndex(
                name: "IX_Sublineage_LineageId",
                table: "Sublineages",
                newName: "IX_Sublineages_LineageId");

            migrationBuilder.RenameIndex(
                name: "IX_Sublineage_CreatorId",
                table: "Sublineages",
                newName: "IX_Sublineages_CreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Subclass_CreatorId",
                table: "Subclasses",
                newName: "IX_Subclasses_CreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Subclass_ClassId",
                table: "Subclasses",
                newName: "IX_Subclasses_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Spell_SublineageId",
                table: "Spells",
                newName: "IX_Spells_SublineageId");

            migrationBuilder.RenameIndex(
                name: "IX_Spell_SubclassId",
                table: "Spells",
                newName: "IX_Spells_SubclassId");

            migrationBuilder.RenameIndex(
                name: "IX_Spell_CreatorId",
                table: "Spells",
                newName: "IX_Spells_CreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Spell_ClassId",
                table: "Spells",
                newName: "IX_Spells_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Spell_CharacterId",
                table: "Spells",
                newName: "IX_Spells_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Lineage_CreatorId",
                table: "Lineages",
                newName: "IX_Lineages_CreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Feat_CreatorId",
                table: "Feats",
                newName: "IX_Feats_CreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Feat_CharacterId",
                table: "Feats",
                newName: "IX_Feats_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Background_CreatorId",
                table: "Backgrounds",
                newName: "IX_Backgrounds_CreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Background_CharacterId",
                table: "Backgrounds",
                newName: "IX_Backgrounds_CharacterId");

            migrationBuilder.AlterColumn<string>(
                name: "Weight",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Treasure",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SkinColour",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Personality",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Ideals",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Height",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "HairColour",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Flaws",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EyeColour",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Bonds",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Backstory",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AppearanceDescription",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AlliesAndOrganizations",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AdditionalTraitsAndFeatures",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sublineages",
                table: "Sublineages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subclasses",
                table: "Subclasses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Spells",
                table: "Spells",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lineages",
                table: "Lineages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Feats",
                table: "Feats",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Backgrounds",
                table: "Backgrounds",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Backgrounds_AspNetUsers_CreatorId",
                table: "Backgrounds",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Backgrounds_Characters_CharacterId",
                table: "Backgrounds",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterClasses_Subclasses_SubclassId",
                table: "CharacterClasses",
                column: "SubclassId",
                principalTable: "Subclasses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Lineages_LineageId",
                table: "Characters",
                column: "LineageId",
                principalTable: "Lineages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Sublineages_SublineageId",
                table: "Characters",
                column: "SublineageId",
                principalTable: "Sublineages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feats_AspNetUsers_CreatorId",
                table: "Feats",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Feats_Characters_CharacterId",
                table: "Feats",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Backgrounds_BackgroundId",
                table: "Features",
                column: "BackgroundId",
                principalTable: "Backgrounds",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Lineages_LineageId",
                table: "Features",
                column: "LineageId",
                principalTable: "Lineages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Subclasses_SubclassId",
                table: "Features",
                column: "SubclassId",
                principalTable: "Subclasses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Sublineages_SublineageId",
                table: "Features",
                column: "SublineageId",
                principalTable: "Sublineages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lineages_AspNetUsers_CreatorId",
                table: "Lineages",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Spells_AspNetUsers_CreatorId",
                table: "Spells",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Spells_Characters_CharacterId",
                table: "Spells",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Spells_Classes_ClassId",
                table: "Spells",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Spells_Subclasses_SubclassId",
                table: "Spells",
                column: "SubclassId",
                principalTable: "Subclasses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Spells_Sublineages_SublineageId",
                table: "Spells",
                column: "SublineageId",
                principalTable: "Sublineages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StatBoosts_Lineages_LineageId",
                table: "StatBoosts",
                column: "LineageId",
                principalTable: "Lineages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StatBoosts_Sublineages_SublineageId",
                table: "StatBoosts",
                column: "SublineageId",
                principalTable: "Sublineages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subclasses_AspNetUsers_CreatorId",
                table: "Subclasses",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subclasses_Classes_ClassId",
                table: "Subclasses",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sublineages_AspNetUsers_CreatorId",
                table: "Sublineages",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sublineages_Lineages_LineageId",
                table: "Sublineages",
                column: "LineageId",
                principalTable: "Lineages",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backgrounds_AspNetUsers_CreatorId",
                table: "Backgrounds");

            migrationBuilder.DropForeignKey(
                name: "FK_Backgrounds_Characters_CharacterId",
                table: "Backgrounds");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterClasses_Subclasses_SubclassId",
                table: "CharacterClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Lineages_LineageId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Sublineages_SublineageId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Feats_AspNetUsers_CreatorId",
                table: "Feats");

            migrationBuilder.DropForeignKey(
                name: "FK_Feats_Characters_CharacterId",
                table: "Feats");

            migrationBuilder.DropForeignKey(
                name: "FK_Features_Backgrounds_BackgroundId",
                table: "Features");

            migrationBuilder.DropForeignKey(
                name: "FK_Features_Lineages_LineageId",
                table: "Features");

            migrationBuilder.DropForeignKey(
                name: "FK_Features_Subclasses_SubclassId",
                table: "Features");

            migrationBuilder.DropForeignKey(
                name: "FK_Features_Sublineages_SublineageId",
                table: "Features");

            migrationBuilder.DropForeignKey(
                name: "FK_Lineages_AspNetUsers_CreatorId",
                table: "Lineages");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_AspNetUsers_CreatorId",
                table: "Spells");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_Characters_CharacterId",
                table: "Spells");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_Classes_ClassId",
                table: "Spells");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_Subclasses_SubclassId",
                table: "Spells");

            migrationBuilder.DropForeignKey(
                name: "FK_Spells_Sublineages_SublineageId",
                table: "Spells");

            migrationBuilder.DropForeignKey(
                name: "FK_StatBoosts_Lineages_LineageId",
                table: "StatBoosts");

            migrationBuilder.DropForeignKey(
                name: "FK_StatBoosts_Sublineages_SublineageId",
                table: "StatBoosts");

            migrationBuilder.DropForeignKey(
                name: "FK_Subclasses_AspNetUsers_CreatorId",
                table: "Subclasses");

            migrationBuilder.DropForeignKey(
                name: "FK_Subclasses_Classes_ClassId",
                table: "Subclasses");

            migrationBuilder.DropForeignKey(
                name: "FK_Sublineages_AspNetUsers_CreatorId",
                table: "Sublineages");

            migrationBuilder.DropForeignKey(
                name: "FK_Sublineages_Lineages_LineageId",
                table: "Sublineages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sublineages",
                table: "Sublineages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subclasses",
                table: "Subclasses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Spells",
                table: "Spells");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lineages",
                table: "Lineages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Feats",
                table: "Feats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Backgrounds",
                table: "Backgrounds");

            migrationBuilder.RenameTable(
                name: "Sublineages",
                newName: "Sublineage");

            migrationBuilder.RenameTable(
                name: "Subclasses",
                newName: "Subclass");

            migrationBuilder.RenameTable(
                name: "Spells",
                newName: "Spell");

            migrationBuilder.RenameTable(
                name: "Lineages",
                newName: "Lineage");

            migrationBuilder.RenameTable(
                name: "Feats",
                newName: "Feat");

            migrationBuilder.RenameTable(
                name: "Backgrounds",
                newName: "Background");

            migrationBuilder.RenameIndex(
                name: "IX_Sublineages_LineageId",
                table: "Sublineage",
                newName: "IX_Sublineage_LineageId");

            migrationBuilder.RenameIndex(
                name: "IX_Sublineages_CreatorId",
                table: "Sublineage",
                newName: "IX_Sublineage_CreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Subclasses_CreatorId",
                table: "Subclass",
                newName: "IX_Subclass_CreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Subclasses_ClassId",
                table: "Subclass",
                newName: "IX_Subclass_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Spells_SublineageId",
                table: "Spell",
                newName: "IX_Spell_SublineageId");

            migrationBuilder.RenameIndex(
                name: "IX_Spells_SubclassId",
                table: "Spell",
                newName: "IX_Spell_SubclassId");

            migrationBuilder.RenameIndex(
                name: "IX_Spells_CreatorId",
                table: "Spell",
                newName: "IX_Spell_CreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Spells_ClassId",
                table: "Spell",
                newName: "IX_Spell_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Spells_CharacterId",
                table: "Spell",
                newName: "IX_Spell_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Lineages_CreatorId",
                table: "Lineage",
                newName: "IX_Lineage_CreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Feats_CreatorId",
                table: "Feat",
                newName: "IX_Feat_CreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Feats_CharacterId",
                table: "Feat",
                newName: "IX_Feat_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Backgrounds_CreatorId",
                table: "Background",
                newName: "IX_Background_CreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Backgrounds_CharacterId",
                table: "Background",
                newName: "IX_Background_CharacterId");

            migrationBuilder.AlterColumn<string>(
                name: "Weight",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Treasure",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SkinColour",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Personality",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ideals",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Height",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HairColour",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Flaws",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EyeColour",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Bonds",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Backstory",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AppearanceDescription",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AlliesAndOrganizations",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AdditionalTraitsAndFeatures",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sublineage",
                table: "Sublineage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subclass",
                table: "Subclass",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Spell",
                table: "Spell",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lineage",
                table: "Lineage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Feat",
                table: "Feat",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Background",
                table: "Background",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Background_AspNetUsers_CreatorId",
                table: "Background",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Background_Characters_CharacterId",
                table: "Background",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterClasses_Subclass_SubclassId",
                table: "CharacterClasses",
                column: "SubclassId",
                principalTable: "Subclass",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Lineage_LineageId",
                table: "Characters",
                column: "LineageId",
                principalTable: "Lineage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Sublineage_SublineageId",
                table: "Characters",
                column: "SublineageId",
                principalTable: "Sublineage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feat_AspNetUsers_CreatorId",
                table: "Feat",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Feat_Characters_CharacterId",
                table: "Feat",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Background_BackgroundId",
                table: "Features",
                column: "BackgroundId",
                principalTable: "Background",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Lineage_LineageId",
                table: "Features",
                column: "LineageId",
                principalTable: "Lineage",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Subclass_SubclassId",
                table: "Features",
                column: "SubclassId",
                principalTable: "Subclass",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Features_Sublineage_SublineageId",
                table: "Features",
                column: "SublineageId",
                principalTable: "Sublineage",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lineage_AspNetUsers_CreatorId",
                table: "Lineage",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Spell_AspNetUsers_CreatorId",
                table: "Spell",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Spell_Characters_CharacterId",
                table: "Spell",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Spell_Classes_ClassId",
                table: "Spell",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Spell_Subclass_SubclassId",
                table: "Spell",
                column: "SubclassId",
                principalTable: "Subclass",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Spell_Sublineage_SublineageId",
                table: "Spell",
                column: "SublineageId",
                principalTable: "Sublineage",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StatBoosts_Lineage_LineageId",
                table: "StatBoosts",
                column: "LineageId",
                principalTable: "Lineage",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StatBoosts_Sublineage_SublineageId",
                table: "StatBoosts",
                column: "SublineageId",
                principalTable: "Sublineage",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subclass_AspNetUsers_CreatorId",
                table: "Subclass",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subclass_Classes_ClassId",
                table: "Subclass",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sublineage_AspNetUsers_CreatorId",
                table: "Sublineage",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sublineage_Lineage_LineageId",
                table: "Sublineage",
                column: "LineageId",
                principalTable: "Lineage",
                principalColumn: "Id");
        }
    }
}
