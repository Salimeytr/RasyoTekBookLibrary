using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLibrary.Dal.Migrations
{
    public partial class writer2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WriterContact",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WriterContact",
                table: "Writers");
        }
    }
}
