namespace InvoicePI.Application.Dto;

public class CustomerDetailDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public string NIP { get; set; }
    public string Segment { get; set; }
    public bool IsActive { get; set; }
    public string Street { get; set; }
    public string StreetNumber { get; set; }
    public string Building { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
    public int CountryId { get; set; }
    public string Phone { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
    public string Fax { get; set; }
    public virtual IEnumerable<InvoiceDto> Invoices { get; set; }

}
