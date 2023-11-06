using HiQPdf;
using Microsoft.Extensions.DependencyInjection;
using RazorLight;

namespace InvoicePI.Infrastructure.Reports;

public static class Extensions
{
    public static IServiceCollection AddHtmlToPdf(this IServiceCollection services)
    {
        HtmlToPdf htmlToPdfConverter = new HtmlToPdf();

        htmlToPdfConverter.Document.PageSize = PdfPageSize.A4;
        htmlToPdfConverter.Document.PageOrientation = PdfPageOrientation.Portrait;
        htmlToPdfConverter.Document.Margins = new PdfMargins(5);
        htmlToPdfConverter.WaitBeforeConvert = 0;
        
        return services.AddSingleton(htmlToPdfConverter);
    }

    public static IServiceCollection AddRazorLightEngine(this IServiceCollection services)
    {
        IRazorLightEngine engine = new RazorLightEngineBuilder()
                        .UseMemoryCachingProvider()
                        .Build();

        return services.AddSingleton(engine);
    }
}