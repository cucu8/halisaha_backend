using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace halisaha_backend.Migrations
{
    /// <inheritdoc />
    public partial class RenameAstroturfToPitch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Astroturfs_AstroturfId",
                table: "Appointments");

            migrationBuilder.RenameTable(
                name: "Astroturfs",
                newName: "Pitches");

            migrationBuilder.RenameColumn(
                name: "AstroturfId",
                table: "Appointments",
                newName: "PitchId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_AstroturfId",
                table: "Appointments",
                newName: "IX_Appointments_PitchId");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$G6OHi1E7mc8HZINDRoJoqOSmPC/hbdzDZIc5geq4t7A.mkQtYnf8G");

            migrationBuilder.CreateIndex(
                name: "IX_Pitches_DistrictId",
                table: "Pitches",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Pitches_OwnerId",
                table: "Pitches",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Pitches_PitchId",
                table: "Appointments",
                column: "PitchId",
                principalTable: "Pitches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Pitches_PitchId",
                table: "Appointments");

            migrationBuilder.DropTable(
                name: "Pitches");

            migrationBuilder.RenameColumn(
                name: "PitchId",
                table: "Appointments",
                newName: "AstroturfId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_PitchId",
                table: "Appointments",
                newName: "IX_Appointments_AstroturfId");

            migrationBuilder.CreateTable(
                name: "Astroturfs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DistrictId = table.Column<int>(type: "integer", nullable: false),
                    OwnerId = table.Column<int>(type: "integer", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Astroturfs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Astroturfs_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Astroturfs_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$JiIyZ/4VErwDjOMOoLCbzuCDFUviwWehh7OGTNDi2REzR.9xv77Uq");

            migrationBuilder.CreateIndex(
                name: "IX_Astroturfs_DistrictId",
                table: "Astroturfs",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Astroturfs_OwnerId",
                table: "Astroturfs",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Astroturfs_AstroturfId",
                table: "Appointments",
                column: "AstroturfId",
                principalTable: "Astroturfs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
