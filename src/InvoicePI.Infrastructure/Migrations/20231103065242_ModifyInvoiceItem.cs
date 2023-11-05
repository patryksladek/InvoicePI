using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoicePI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifyInvoiceItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Vat",
                schema: "invoices",
                table: "InvoiceItems",
                newName: "Price");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                schema: "invoices",
                table: "InvoiceItems",
                newName: "Vat");
        }
    }
}
