namespace InvoicePI.Application.Dto;

public class InvoiceItemDto
{
    public string Product { get; set; }
    public int Quantity { get; set; }
    public decimal Net { get; set; }
    public decimal Vat { get; set; }
    public decimal Gross { get; set; }
    public string Currency { get; set; }
}
