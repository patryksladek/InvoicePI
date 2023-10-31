using InvoicePI.Domain.Entities.Definitions;
using InvoicePI.Domain.Entities.Invoices;
using InvoicePI.Domain.Enums;

namespace InvoicePI.Domain.Entities.Products;

public class Product : AuditableEntity
{
    public string Name { get; set; }
    public string Code { get; set; }
    public ProductType Type { get; set; }
    public string Barcode { get; set; }
    public ProductBarcodeType BarcodeType { get; set; }
    public int CurrencyId { get; set; }
    public Currency Currency { get; set; }
    public int UnitId { get; set; }
    public Unit Unit { get; set; }
    public int VatRateId { get; set; }
    public VatRate VatRate { get; set; }
    public decimal NetPrice { get; set; }
    public ICollection<InvoiceItem> InvoiceItems { get; set; }
}
