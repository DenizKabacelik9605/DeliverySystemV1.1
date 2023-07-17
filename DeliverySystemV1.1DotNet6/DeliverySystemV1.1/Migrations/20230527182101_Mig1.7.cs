using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliverySystemV1._1.Migrations
{
    public partial class Mig17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CargoShipments",
                columns: new[] { "ShipmentId", "RecipientId", "SenderId" },
                values: new object[,]
                {
                    { 2, 3, 1 },
                    { 4, 4, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CargoShipments",
                keyColumn: "ShipmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CargoShipments",
                keyColumn: "ShipmentId",
                keyValue: 4);
        }
    }
}
