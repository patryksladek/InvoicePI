using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoicePI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddOrdinalNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrdinalNumber",
                schema: "invoices",
                table: "InvoiceItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrdinalNumber",
                schema: "invoices",
                table: "InvoiceItems");
        }
    }
}
