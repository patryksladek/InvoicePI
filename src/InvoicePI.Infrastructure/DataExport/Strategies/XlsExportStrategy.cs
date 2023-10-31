using InvoicePI.Infrastructure.DataExport.Abstractions;
using OfficeOpenXml;

namespace InvoicePI.Infrastructure.DataExport.Strategies;

public class XlsExportStrategy : IExportStrategy
{
    public void Export<T>(IList<T> data, string filePath)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("Records");
            worksheet.Cells.LoadFromCollection(data, true);

            package.SaveAs(new FileInfo(filePath));
        }
    }
}
