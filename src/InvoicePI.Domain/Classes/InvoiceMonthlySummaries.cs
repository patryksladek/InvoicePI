namespace InvoicePI.Domain.Classes;

public class InvoiceMonthlySummaries
{
    public decimal Net { get; set; }
    public decimal Vat { get; set; }
    public decimal Gross { get; set; }
    public string Currency { get; set; }
    public int Year { get; set; }
    public int Month { get; set; }
}
