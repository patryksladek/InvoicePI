using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Enums;
using MediatR;

namespace InvoicePI.Application.Queries.Reports.GenerateNumberOfCustomersInCountry;

internal class GenerateCustomersInCountryQueryHandler : IRequestHandler<GenerateCustomersInCountryQuery, byte[]>
{
    private readonly IReportGenerator _reportGenerator;
    private readonly IReportRepository _reportRepository;

    public GenerateCustomersInCountryQueryHandler(IReportGenerator reportGenerator, IReportRepository reportRepository)
    {
        _reportGenerator = reportGenerator;
        _reportRepository = reportRepository;
    }

    public async Task<byte[]> Handle(GenerateCustomersInCountryQuery request, CancellationToken cancellationToken)
    {
        var reportData = await _reportRepository.GetNumberOfCustomersInCountryAsync();
        var report = await _reportGenerator.GenerateReportAsync(ReportTemplate.NumberOfCustomersInCountry, reportData);
        return report;
    }
}

