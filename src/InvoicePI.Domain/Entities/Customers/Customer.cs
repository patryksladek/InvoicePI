using InvoicePI.Domain.Entities.Invoices;
using InvoicePI.Domain.Enums;

namespace InvoicePI.Domain.Entities.Customers;

public class Customer : AuditableEntity
{
    public string Name { get; set; }
    public string Code { get; set; }
    public string NIP { get; set; }
    public CustomerSegment? Segment { get; set; }
    public Address Address { get; set; }
    public Contact Contact { get; set; }
    public bool IsActive { get; set; }
    public ICollection<Invoice> Invoices { get; set; }
}
