using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace halisaha_backend.Migrations
{
    /// <inheritdoc />
    public partial class AddPitchContactPhoneNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactPhoneNumber",
                table: "Pitches",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactPhoneNumber",
                table: "Pitches");
        }
    }
}
