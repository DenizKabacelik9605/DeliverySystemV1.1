using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliverySystemV1._1.Migrations
{
    public partial class _19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CargoShipments",
                keyColumn: "ShipmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CargoShipments",
                keyColumn: "ShipmentId",
                keyValue: 4);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "CargoShipments",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TargetCargoAddress",
                table: "CargoShipments",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Test",
                table: "CargoShipments",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "CargoShipments",
                columns: new[] { "ShipmentId", "Discriminator", "RecipientId", "SenderId", "TargetCargoAddress" },
                values: new object[,]
                {
                    { 2, "CargoShipments", 3, 1, "Ankara" },
                    { 4, "CargoShipments", 4, 3, "İstanbul" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "CargoShipments");

            migrationBuilder.DropColumn(
                name: "TargetCargoAddress",
                table: "CargoShipments");

            migrationBuilder.DropColumn(
                name: "Test",
                table: "CargoShipments");
        }
    }
}
