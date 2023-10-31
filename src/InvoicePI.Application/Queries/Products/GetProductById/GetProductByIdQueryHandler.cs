using InvoicePI.Application.Dto;
using InvoicePI.Application.Queries.Customers.GetCustomerById;
using InvoicePI.Domain.Abstractions;
using MediatR;

namespace InvoicePI.Application.Queries.Products.GetProductById;

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDetailDto>
{
    private readonly IProductReadOnlyRepository _productReadOnlyRepository;

    public GetProductByIdQueryHandler(IProductReadOnlyRepository productReadOnlyRepository)
    {
        _productReadOnlyRepository = productReadOnlyRepository;
    }

    public async Task<ProductDetailDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var product = await _productReadOnlyRepository.GetByIdWithDetailAsync(request.Id);

        var productDto = new ProductDetailDto()
        {
            Id = product.Id,
            Name = product.Name,
            Code = product.Code,
            ProductType = product.Type.ToString(),
            Barcode = product.Barcode,
            ProductBarcodeType = product.BarcodeType.ToString(),
            CurrencyId = product.CurrencyId,
            UnitId = product.UnitId,
            VatRateId = product.VatRateId,
            Price = product.NetPrice
        };

        return productDto;
    }
}
