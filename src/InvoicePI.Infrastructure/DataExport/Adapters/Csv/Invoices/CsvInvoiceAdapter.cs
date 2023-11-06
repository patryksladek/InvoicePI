using InvoicePI.Application.Dto;

namespace InvoicePI.Infrastructure.DataExport.Adapters.CSV.Invoices;

public class CsvInvoiceAdapter
{
    public static IList<Invoice> Convert(InvoiceDto invoiceDto, IEnumerable<InvoiceItemDto> invoiceItemsDto)
    {
        IList<Invoice> invoice = new List<Invoice>();
        
        foreach (InvoiceItemDto invoiceItemDto in invoiceDto.InvoiceItems)
            new Invoice(invoiceDto, invoiceItemDto);
       
        return invoice;
    }

    public static IList<Invoice> Convert(IList<InvoiceDto> invoiceDtos)
    {
        IList<Invoice> invoice = new List<Invoice>();

        foreach (InvoiceDto invoiceDto in invoiceDtos)
            foreach (InvoiceItemDto invoiceItemDto in invoiceDto.InvoiceItems)
                invoice.Add(new Invoice(invoiceDto, invoiceItemDto));
        
        return invoice;
    }
}
