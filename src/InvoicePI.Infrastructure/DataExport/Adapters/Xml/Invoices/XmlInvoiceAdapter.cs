using InvoicePI.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicePI.Infrastructure.DataExport.Adapters.Xml.Invoices;

public class XmlInvoiceAdapter
{
    public static Invoice Convert(InvoiceDto invoiceDtos)
        => (Invoice)invoiceDtos;
    
    public static IList<Invoice> Convert(IList<InvoiceDto> invoiceDtos)
        =>  invoiceDtos.Select(dto => (Invoice)dto).ToList();
}
