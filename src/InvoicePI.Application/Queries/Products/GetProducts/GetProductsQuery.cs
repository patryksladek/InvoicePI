using InvoicePI.Application.Dto;
using MediatR;

namespace InvoicePI.Application.Queries.Products.GetProducts;

public record GetProductsQuery() : IRequest<IReadOnlyCollection<ProductDto>>;