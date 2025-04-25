using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreApplication.Migrations
{
    /// <inheritdoc />
    public partial class addedAutoMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Meter",
                table: "People");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Meter",
                table: "People",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
