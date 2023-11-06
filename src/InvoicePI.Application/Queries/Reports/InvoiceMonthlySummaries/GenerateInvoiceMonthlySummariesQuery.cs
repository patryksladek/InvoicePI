using MediatR;

namespace InvoicePI.Application.Queries.Reports.InvoiceMonthlySummaries;

public record GenerateInvoiceMonthlySummariesQuery() : IRequest<byte[]>;
