using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class LinkUserAndWorkingExperiences : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_workingExperiences_UserId",
                table: "workingExperiences",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_workingExperiences_users_UserId",
                table: "workingExperiences",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_workingExperiences_users_UserId",
                table: "workingExperiences");

            migrationBuilder.DropIndex(
                name: "IX_workingExperiences_UserId",
                table: "workingExperiences");
        }
    }
}
