using HiQPdf;
using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Enums;
using InvoicePI.Infrastructure.Reports.Helpers;
using RazorLight;
using System.Reflection;

namespace InvoicePI.Infrastructure.Reports;

public class PdfReportGenerator : IReportGenerator
{
    private readonly HtmlToPdf _htmlToPdf;
    private readonly IRazorLightEngine _engine;

    public PdfReportGenerator(HtmlToPdf htmlToPdf, IRazorLightEngine engine)
    {
        _htmlToPdf = htmlToPdf;
        _engine = engine;
    }

    public async Task<byte[]> GenerateReportAsync(ReportTemplate reportTemplate, dynamic model)
    {
        string template = $"InvoicePI.Infrastructure.Reports.Templates.{reportTemplate}.cshtml";

        var executingAssembly = Assembly.GetExecutingAssembly();
        string content = EmbeddedResourceHelper.GetResourceAsString(executingAssembly, template);
        
        string result = await _engine.CompileRenderStringAsync(template, content, model);

        byte[] fileContents = _htmlToPdf.ConvertHtmlToMemory(result, string.Empty);

        return fileContents;
    }
}
