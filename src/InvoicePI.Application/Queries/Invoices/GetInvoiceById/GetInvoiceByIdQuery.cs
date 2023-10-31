using InvoicePI.Application.Dto;
using MediatR;

namespace InvoicePI.Application.Queries.Invoices.GetProductById;

public record GetInvoiceByIdQuery(int Id) : IRequest<InvoiceDetailDto>;
