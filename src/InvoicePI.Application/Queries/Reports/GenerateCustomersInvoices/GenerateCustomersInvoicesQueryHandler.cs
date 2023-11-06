using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Enums;
using MediatR;

namespace InvoicePI.Application.Queries.Reports.GenerateCustomersInvoices;

internal class GenerateCustomersInvoicesQueryHandler : IRequestHandler<GenerateCustomersInvoicesQuery, byte[]>
{
    private readonly IReportGenerator _reportGenerator;
    private readonly IReportRepository _reportRepository;

    public GenerateCustomersInvoicesQueryHandler(IReportGenerator reportGenerator, IReportRepository reportRepository)
    {
        _reportGenerator = reportGenerator;
        _reportRepository = reportRepository;
    }

    public async Task<byte[]> Handle(GenerateCustomersInvoicesQuery request, CancellationToken cancellationToken)
    {
        var reportData = await _reportRepository.GetCustomersInvoicesAsync(request.CustomerId);
        var report = await _reportGenerator.GenerateReportAsync(ReportTemplate.CustomersInvoicesWithTotalAmounts, reportData);
        return report;
    }
}

