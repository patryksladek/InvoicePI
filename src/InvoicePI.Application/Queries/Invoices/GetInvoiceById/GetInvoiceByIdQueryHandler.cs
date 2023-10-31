using InvoicePI.Application.Dto;
using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Enums;
using MediatR;

namespace InvoicePI.Application.Queries.Invoices.GetProductById;

public class GetInvoiceByIdQueryHandler : IRequestHandler<GetInvoiceByIdQuery, InvoiceDetailDto>
{
    private readonly IInvoiceReadOnlyRepository _invoiceReadOnlyRepository;

    public GetInvoiceByIdQueryHandler(IInvoiceReadOnlyRepository invoiceReadOnlyRepository)
    {
        _invoiceReadOnlyRepository = invoiceReadOnlyRepository;
    }

    public async Task<InvoiceDetailDto> Handle(GetInvoiceByIdQuery request, CancellationToken cancellationToken)
    {
        var invoice = await _invoiceReadOnlyRepository.GetByIdWithDetailAsync(request.Id);

        var invoiceDto = new InvoiceDetailDto();
        invoiceDto.Id = invoice.Id;
        invoiceDto.IsApproved = invoice.Status == InvoiceStatus.Confirmed ? true : false;
        invoiceDto.Number = invoice.Number;
        invoiceDto.Date = invoice.Date;
        invoiceDto.CustomerId = invoice.CustomerId;
        invoiceDto.Description = invoice.Description;
        invoiceDto.Net = invoice.Net;
        invoiceDto.Vat = invoice.Vat;
        invoiceDto.Gross = invoice.Gross;
        invoiceDto.CurrencyId = invoice.CurrencyId;
        invoiceDto.InvoiceItems = new List<InvoiceItemDetailDto>();

        foreach (var invoiceItem in invoice.InvoiceItems)
        {
            invoiceDto.InvoiceItems.Add(new InvoiceItemDetailDto()
            {
                ProductId = invoiceItem.ProductId,
                Product = invoiceItem.Product.Name,
                Quantity = invoiceItem.Quantity,
                Net = invoiceItem.Net,
                Vat = invoiceItem.Vat,
                Gross = invoiceItem.Gross,
                CurrencyId = invoiceItem.CurrencyId,
                Currency = invoiceItem.Currency.Symbol,
                VatRateId = invoiceItem.VatRateId,
                VatRate = invoiceItem.VatRate.Symbol,

            });
        }

        return invoiceDto;
    }
}
