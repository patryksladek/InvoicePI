namespace InvoicePI.Infrastructure.DataExport.Abstractions;

public interface IExportStrategy
{
    void Export<T>(IList<T> data, string filePath);
}
