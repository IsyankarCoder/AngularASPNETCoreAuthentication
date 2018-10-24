using Microsoft.EntityFrameworkCore.Migrations;

namespace JsonWebTokenWithAngularAspNetCore.Migrations
{
    public partial class yy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Memet",
                table: "JobSeekers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Memet",
                table: "JobSeekers");
        }
    }
}
