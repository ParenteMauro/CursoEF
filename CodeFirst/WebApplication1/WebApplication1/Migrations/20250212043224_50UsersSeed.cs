using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class _50UsersSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Email", "Password", "UserName" },
                values: new object[,]
                {
                    { 25, "user25@gmail.com", "123", "user25" },
                    { 26, "user26@gmail.com", "123", "user26" },
                    { 27, "user27@gmail.com", "123", "user27" },
                    { 28, "user28@gmail.com", "123", "user28" },
                    { 29, "user29@gmail.com", "123", "user29" },
                    { 30, "user30@gmail.com", "123", "user30" },
                    { 31, "user31@gmail.com", "123", "user31" },
                    { 32, "user32@gmail.com", "123", "user32" },
                    { 33, "user33@gmail.com", "123", "user33" },
                    { 34, "user34@gmail.com", "123", "user34" },
                    { 35, "user35@gmail.com", "123", "user35" },
                    { 36, "user36@gmail.com", "123", "user36" },
                    { 37, "user37@gmail.com", "123", "user37" },
                    { 38, "user38@gmail.com", "123", "user38" },
                    { 39, "user39@gmail.com", "123", "user39" },
                    { 40, "user40@gmail.com", "123", "user40" },
                    { 41, "user41@gmail.com", "123", "user41" },
                    { 42, "user42@gmail.com", "123", "user42" },
                    { 43, "user43@gmail.com", "123", "user43" },
                    { 44, "user44@gmail.com", "123", "user44" },
                    { 45, "user45@gmail.com", "123", "user45" },
                    { 46, "user46@gmail.com", "123", "user46" },
                    { 47, "user47@gmail.com", "123", "user47" },
                    { 48, "user48@gmail.com", "123", "user48" },
                    { 49, "user49@gmail.com", "123", "user49" },
                    { 50, "user50@gmail.com", "123", "user50" },
                    { 51, "user51@gmail.com", "123", "user51" },
                    { 52, "user52@gmail.com", "123", "user52" },
                    { 53, "user53@gmail.com", "123", "user53" },
                    { 54, "user54@gmail.com", "123", "user54" },
                    { 55, "user55@gmail.com", "123", "user55" },
                    { 56, "user56@gmail.com", "123", "user56" },
                    { 57, "user57@gmail.com", "123", "user57" },
                    { 58, "user58@gmail.com", "123", "user58" },
                    { 59, "user59@gmail.com", "123", "user59" },
                    { 60, "user60@gmail.com", "123", "user60" },
                    { 61, "user61@gmail.com", "123", "user61" },
                    { 62, "user62@gmail.com", "123", "user62" },
                    { 63, "user63@gmail.com", "123", "user63" },
                    { 64, "user64@gmail.com", "123", "user64" },
                    { 65, "user65@gmail.com", "123", "user65" },
                    { 66, "user66@gmail.com", "123", "user66" },
                    { 67, "user67@gmail.com", "123", "user67" },
                    { 68, "user68@gmail.com", "123", "user68" },
                    { 69, "user69@gmail.com", "123", "user69" },
                    { 70, "user70@gmail.com", "123", "user70" },
                    { 71, "user71@gmail.com", "123", "user71" },
                    { 72, "user72@gmail.com", "123", "user72" },
                    { 73, "user73@gmail.com", "123", "user73" },
                    { 74, "user74@gmail.com", "123", "user74" },
                    { 75, "user75@gmail.com", "123", "user75" },
                    { 76, "user76@gmail.com", "123", "user76" },
                    { 77, "user77@gmail.com", "123", "user77" },
                    { 78, "user78@gmail.com", "123", "user78" },
                    { 79, "user79@gmail.com", "123", "user79" },
                    { 80, "user80@gmail.com", "123", "user80" },
                    { 81, "user81@gmail.com", "123", "user81" },
                    { 82, "user82@gmail.com", "123", "user82" },
                    { 83, "user83@gmail.com", "123", "user83" },
                    { 84, "user84@gmail.com", "123", "user84" },
                    { 85, "user85@gmail.com", "123", "user85" },
                    { 86, "user86@gmail.com", "123", "user86" },
                    { 87, "user87@gmail.com", "123", "user87" },
                    { 88, "user88@gmail.com", "123", "user88" },
                    { 89, "user89@gmail.com", "123", "user89" },
                    { 90, "user90@gmail.com", "123", "user90" },
                    { 91, "user91@gmail.com", "123", "user91" },
                    { 92, "user92@gmail.com", "123", "user92" },
                    { 93, "user93@gmail.com", "123", "user93" },
                    { 94, "user94@gmail.com", "123", "user94" },
                    { 95, "user95@gmail.com", "123", "user95" },
                    { 96, "user96@gmail.com", "123", "user96" },
                    { 97, "user97@gmail.com", "123", "user97" },
                    { 98, "user98@gmail.com", "123", "user98" },
                    { 99, "user99@gmail.com", "123", "user99" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Email", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "user1@gmail.com", "123", "user1" },
                    { 2, "user2@gmail.com", "123", "user2" }
                });
        }
    }
}
