using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeligatiTechWeb2.Migrations
{
    /// <inheritdoc />
    public partial class Component : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Component",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Component",
                table: "Categories");
        }
    }
}
