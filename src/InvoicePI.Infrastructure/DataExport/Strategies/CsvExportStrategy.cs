using CsvHelper;
using InvoicePI.Infrastructure.DataExport.Abstractions;
using System.Globalization;

namespace InvoicePI.Infrastructure.DataExport.Strategies;

public class CsvExportStrategy : IExportStrategy
{
    public void Export<T>(IList<T> data, string filePath)
    {
        using (var writer = new StreamWriter(filePath))
        using (var csv = new CsvWriter(writer, culture: CultureInfo.CurrentCulture))
        {
            csv.WriteRecords(data);
        }
    }
}
