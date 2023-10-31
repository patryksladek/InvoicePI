using InvoicePI.Application.Dto;
using MediatR;

namespace InvoicePI.Application.Queries.Products.GetProductById;

public record GetProductByIdQuery(int Id) : IRequest<ProductDetailDto>;
