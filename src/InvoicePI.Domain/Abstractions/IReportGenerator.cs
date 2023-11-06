using InvoicePI.Domain.Enums;
using System.Dynamic;

namespace InvoicePI.Domain.Abstractions;

public interface IReportGenerator
{
    Task<byte[]> GenerateReportAsync(ReportTemplate reportTemplate, dynamic model = null);
}
