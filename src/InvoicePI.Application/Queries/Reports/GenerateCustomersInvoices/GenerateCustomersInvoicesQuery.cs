using MediatR;

namespace InvoicePI.Application.Queries.Reports.GenerateCustomersInvoices;

public record GenerateCustomersInvoicesQuery(int CustomerId) : IRequest<byte[]>;
