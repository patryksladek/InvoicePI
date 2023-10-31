using MediatR;

namespace InvoicePI.Application.Commands.Customers.EditCusotmer;

public class EditProductCommand : IRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public int ProductType { get; set; }
    public string Barcode { get; set; }
    public int ProductBarcodeType { get; set; }
    public int CurrencyId { get; set; }
    public int UnitId { get; set; }
    public int VatRateId { get; set; }
    public decimal Price { get; set; }
}
