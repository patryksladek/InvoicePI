using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Enums;
using MediatR;

namespace InvoicePI.Application.Queries.Reports.InvoiceMonthlySummaries;

internal class GenerateInvoiceMonthlySummariesQueryHandler : IRequestHandler<GenerateInvoiceMonthlySummariesQuery, byte[]>
{
    private readonly IReportGenerator _reportGenerator;
    private readonly IReportRepository _reportRepository;

    public GenerateInvoiceMonthlySummariesQueryHandler(IReportGenerator reportGenerator, IReportRepository reportRepository)
    {
        _reportGenerator = reportGenerator;
        _reportRepository = reportRepository;
    }

    public async Task<byte[]> Handle(GenerateInvoiceMonthlySummariesQuery request, CancellationToken cancellationToken)
    {
        var reportData = await _reportRepository.GetInvoiceMonthlySummariesAsync();
        var report = await _reportGenerator.GenerateReportAsync(ReportTemplate.TotalInvoicesOnMonthlyBasis, reportData);
        return report;
    }
}
