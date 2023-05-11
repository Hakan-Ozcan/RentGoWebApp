using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class menuupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubMenuID",
                table: "Menus");

            migrationBuilder.RenameColumn(
                name: "ProgramID",
                table: "Menus",
                newName: "MenuName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MenuName",
                table: "Menus",
                newName: "ProgramID");

            migrationBuilder.AddColumn<int>(
                name: "SubMenuID",
                table: "Menus",
                type: "int",
                nullable: true);
        }
    }
}
