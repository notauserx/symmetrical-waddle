using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Context.Migrations.Migrations;

public partial class AddIsDeactivatedToListings : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<bool>(
            name: "IsDeactivated",
            table: "CarListings",
            type: "bit",
            nullable: false,
            defaultValue: false);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "IsDeactivated",
            table: "CarListings");
    }
}
