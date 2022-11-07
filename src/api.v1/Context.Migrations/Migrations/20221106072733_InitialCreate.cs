using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Context.Migrations.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarListings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaKe = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarListings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarListings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DisplayName", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("0aed55c3-b593-49da-b1ff-6532fc46b6c4"), "Bill Autos", "billieHay@somedomain.com", "Bill", "Hayden" },
                    { new Guid("50ec3410-bf52-4cc6-b7bf-61e306b92593"), "Customer", "jamiesGetsBilled@somedomain.com", "James", "Bill" },
                    { new Guid("745ee7e0-d756-485f-8f1d-8b2bccc007fe"), "Customer", "oOliviaO@somedomain.com", "Olivia", "Spencer" },
                    { new Guid("874313be-3037-4fb6-be0b-285f1f5e9c3e"), "Admin", "admin@carrentalcorporation.com", "John", "Doe" },
                    { new Guid("ceae382c-70f8-46d1-8ec1-cb7d3b4abd9f"), "Autos at High Park Blvd", "careronyo@autosathighpark.com", "Cameron", "Yo" },
                    { new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33"), "Developer", "janedoe@carrentalcorporation.com", "Jane", "Doe" }
                });

            migrationBuilder.InsertData(
                table: "CarListings",
                columns: new[] { "Id", "MaKe", "Model", "UserId", "Year" },
                values: new object[,]
                {
                    { new Guid("035bea3a-034a-41b4-8457-90fc4b0df2be"), "Toyota", "Camry", new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33"), 2022 },
                    { new Guid("0a87c369-0e77-497c-8af0-660cf0fafbf4"), "Toyota", "Camry", new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33"), 2022 },
                    { new Guid("18c55c75-9ef4-4486-afc6-0facda23005d"), "Ford", "Focus", new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33"), 2022 },
                    { new Guid("35798331-b5aa-4b40-92f5-36254888e62d"), "Hyundai", "Sonata", new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33"), 2022 },
                    { new Guid("497fba56-227f-4a80-8e61-cf91e4aabc4e"), "Toyota", "C-HR", new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33"), 2022 },
                    { new Guid("54c9131c-0392-4155-9565-49d1ebaf7379"), "Ford", "Mustang", new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33"), 2022 },
                    { new Guid("7587c496-5e9e-4cb0-896e-b5215dd3375b"), "Toyota", "Yaris", new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33"), 2022 },
                    { new Guid("7cfba5c5-e1ee-4ab4-a4d0-9bc3dd352187"), "Toyota", "Prius", new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33"), 2022 },
                    { new Guid("ca5ed291-5b42-4276-a726-411f65900e58"), "Toyota", "Avalon", new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33"), 2022 },
                    { new Guid("ea619497-88c1-4886-8bc4-c63ab363f872"), "Toyota", "Camry", new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33"), 2022 },
                    { new Guid("ffc9510d-4c6a-4a4d-8774-d6d647138d06"), "Toyota", "Camry", new Guid("fab81e4b-89d8-43dd-9567-8ffadad4ea33"), 2021 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarListings_UserId",
                table: "CarListings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarListings");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
