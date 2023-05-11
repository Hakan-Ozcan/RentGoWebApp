using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class menutype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuName",
                table: "Menus");

            migrationBuilder.AddColumn<int>(
                name: "MenuNameID",
                table: "Menus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Menus_MenuNameID",
                table: "Menus",
                column: "MenuNameID");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Menus_MenuNameID",
                table: "Menus",
                column: "MenuNameID",
                principalTable: "Menus",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Menus_MenuNameID",
                table: "Menus");

            migrationBuilder.DropIndex(
                name: "IX_Menus_MenuNameID",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "MenuNameID",
                table: "Menus");

            migrationBuilder.AddColumn<string>(
                name: "MenuName",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
