using InvoicePI.Application.Dto;
using InvoicePI.Domain.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace InvoicePI.Application.Queries.Products.GetProducts;

public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IReadOnlyCollection<ProductDto>>
{
    private readonly IProductReadOnlyRepository _productReadOnlyRepository;

    public GetProductsQueryHandler(IProductReadOnlyRepository productReadOnlyRepository)
    {
        _productReadOnlyRepository = productReadOnlyRepository;
    }

    public async Task<IReadOnlyCollection<ProductDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        var products = _productReadOnlyRepository.GetAllAsync();

        var customersDto = await products.Select(x => new ProductDto()
        {
            Id = x.Id,
            Name = x.Name,
            Code = x.Code,
            Barcode = x.Barcode,
            Price = x.NetPrice,
            Currency = x.Currency.Symbol
        })
        .ToListAsync();

        return customersDto;
    }
}
