namespace InvoicePI.Domain.Entities.Customers;

public class Contact : AuditableEntity
{
    public string Phone { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
    public string Fax { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}
