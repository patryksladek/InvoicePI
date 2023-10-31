using InvoicePI.Domain.Entities.Invoices;
using InvoicePI.Domain.Entities.Products;

namespace InvoicePI.Domain.Entities.Definitions;

public class VatRate : BaseEntity
{
    public string Symbol { get; set; }
    public decimal Value { get; set; }
    public ICollection<Product> Products { get; set; }
    public ICollection<InvoiceItem> InvoiceItems { get; set; }
}

