using InvoicePI.Infrastructure.DataExport.Abstractions;

namespace InvoicePI.Infrastructure.DataExport.Strategies;

public class TxtExportStrategy : IExportStrategy
{
    public void Export<T>(IList<T> data, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var item in data)
            {
                writer.WriteLine(item.ToString());
            }
        }
    }
}
