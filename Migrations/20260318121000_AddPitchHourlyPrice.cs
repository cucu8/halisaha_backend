using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace halisaha_backend.Migrations
{
    /// <inheritdoc />
    public partial class AddPitchHourlyPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "HourlyPrice",
                table: "Pitches",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HourlyPrice",
                table: "Pitches");
        }
    }
}
