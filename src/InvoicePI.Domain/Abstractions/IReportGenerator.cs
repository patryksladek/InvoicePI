using InvoicePI.Domain.Enums;

namespace InvoicePI.Domain.Abstractions;

public interface IReportGenerator
{
    Task<byte[]> GenerateReportAsync(ReportTemplate reportTemplate, dynamic model = null);
}
