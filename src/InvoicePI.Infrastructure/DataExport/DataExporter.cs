using InvoicePI.Infrastructure.DataExport.Abstractions;

namespace InvoicePI.Infrastructure.DataExport;

public class DataExporter
{
    private IExportStrategy _exportStrategy;

    public DataExporter(IExportStrategy exportStrategy)
    {
        _exportStrategy = exportStrategy;
    }

    public void SetExportStrategy(IExportStrategy exportStrategy)
    {
        _exportStrategy = exportStrategy;
    }

    public void ExportData<T>(IList<T> data, string filePath)
    {
        _exportStrategy.Export(data, filePath);
    }
}
