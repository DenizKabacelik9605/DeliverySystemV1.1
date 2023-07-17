using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliverySystemV1._1.Migrations
{
    public partial class Mig12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "RecipientId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "Customers");

            migrationBuilder.AddColumn<short>(
                name: "CustomerType",
                table: "Customers",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerType",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Customers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RecipientId",
                table: "Customers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SenderId",
                table: "Customers",
                type: "integer",
                nullable: true);
        }
    }
}
