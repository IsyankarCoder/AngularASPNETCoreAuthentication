using Microsoft.EntityFrameworkCore.Migrations;

namespace JsonWebTokenWithAngularAspNetCore.Migrations
{
    public partial class melike : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Makarna",
                table: "JobSeekers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Makarna",
                table: "JobSeekers");
        }
    }
}
