using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace halisaha_backend.Migrations
{
    /// <inheritdoc />
    public partial class AddPitchFeatures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PitchFeatures",
                columns: table => new
                {
                    PitchId = table.Column<int>(type: "integer", nullable: false),
                    FeatureId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PitchFeatures", x => new { x.PitchId, x.FeatureId });
                    table.ForeignKey(
                        name: "FK_PitchFeatures_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PitchFeatures_Pitches_PitchId",
                        column: x => x.PitchId,
                        principalTable: "Pitches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PitchFeatures_FeatureId",
                table: "PitchFeatures",
                column: "FeatureId");

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Otopark" },
                    { 2, "Kafe / Büfe" },
                    { 3, "Duş" },
                    { 4, "Aydınlatma" },
                    { 5, "Klima (Kapalı Saha)" },
                    { 6, "Çocuk Oyun Alanı" },
                    { 7, "Maç Kaydı" },
                    { 8, "Kiralık Kaleci" },
                    { 9, "Kiralık Krampon" },
                    { 10, "Kiralık Oyuncu" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PitchFeatures");

            migrationBuilder.DropTable(
                name: "Features");
        }
    }
}
