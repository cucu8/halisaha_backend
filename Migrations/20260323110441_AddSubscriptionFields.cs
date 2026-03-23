using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace halisaha_backend.Migrations
{
    /// <inheritdoc />
    public partial class AddSubscriptionFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSubscription",
                table: "Appointments",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "SubscriptionGroupId",
                table: "Appointments",
                type: "uuid",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSubscription",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "SubscriptionGroupId",
                table: "Appointments");
        }
    }
}
