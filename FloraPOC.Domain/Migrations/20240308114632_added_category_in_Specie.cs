using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FloraPOC.Domain.Migrations
{
    /// <inheritdoc />
    public partial class added_category_in_Specie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Species",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Species");
        }
    }
}
