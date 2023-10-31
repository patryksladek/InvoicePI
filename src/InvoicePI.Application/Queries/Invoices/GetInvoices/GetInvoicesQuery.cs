using InvoicePI.Application.Dto;
using MediatR;

namespace InvoicePI.Application.Queries.Invoices.GetProducts;

public record GetInvoicesQuery() : IRequest<IReadOnlyCollection<InvoiceDto>>;