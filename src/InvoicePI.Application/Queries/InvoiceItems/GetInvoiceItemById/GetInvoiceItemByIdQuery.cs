using InvoicePI.Application.Dto;
using MediatR;

namespace InvoicePI.Application.Queries.InvoiceItems.GetInvoiceItemById;

public record GetInvoiceItemByIdQuery(int Id) : IRequest<InvoiceItemDetailDto>;
