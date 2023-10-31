using InvoicePI.Application.Dto;
using MediatR;

namespace InvoicePI.Application.Commands.Products.AddProduct;

public class AddProductCommand : IRequest<ProductDetailDto>
{
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
