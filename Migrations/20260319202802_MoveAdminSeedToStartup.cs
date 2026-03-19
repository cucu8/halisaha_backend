using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace halisaha_backend.Migrations
{
    /// <inheritdoc />
    public partial class MoveAdminSeedToStartup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IsActive", "Name", "PasswordHash", "PhoneNumber", "Role" },
                values: new object[] { 1, true, "Admin", "$2a$11$G6OHi1E7mc8HZINDRoJoqOSmPC/hbdzDZIc5geq4t7A.mkQtYnf8G", "05334281441", 0 });
        }
    }
}
