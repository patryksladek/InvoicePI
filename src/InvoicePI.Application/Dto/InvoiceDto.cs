using InvoicePI.Domain.Entities.Customers;
using System.Numerics;
using System.Xml.Linq;

namespace InvoicePI.Application.Dto;

public class InvoiceDto
{
    public int Id { get; set; }
    public bool IsApproved { get; set; }
    public string Number { get; set; }
    public DateOnly Date { get; set; }
    public string Customer { get; set; }
    public decimal Net { get; set; }
    public decimal Vat { get; set; }
    public decimal Gross { get; set; }
    public string Currency { get; set; }
    public virtual IEnumerable<InvoiceItemDto> InvoiceItems { get; set; }

    public override string ToString()
    {
        return $"{Id} | {IsApproved} | {Number} | {Date} | {Customer} | {Net} | {Vat} | {Gross} | {Currency}";
    }
}
