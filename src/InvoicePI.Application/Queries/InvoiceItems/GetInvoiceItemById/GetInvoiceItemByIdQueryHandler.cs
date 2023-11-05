using InvoicePI.Application.Dto;
using InvoicePI.Application.Queries.InvoiceItems.GetInvoiceItemById;
using InvoicePI.Domain.Abstractions;
using MediatR;

namespace InvoicePI.Application.Queries.Invoices.GetInvoiceItemById;

public class GetInvoiceItemByIdQueryHandler : IRequestHandler<GetInvoiceItemByIdQuery, InvoiceItemDetailDto>
{
    private readonly IInvoiceReadOnlyRepository _invoiceReadOnlyRepository;

    public GetInvoiceItemByIdQueryHandler(IInvoiceReadOnlyRepository invoiceReadOnlyRepository)
    {
        _invoiceReadOnlyRepository = invoiceReadOnlyRepository;
    }

    public async Task<InvoiceItemDetailDto> Handle(GetInvoiceItemByIdQuery request, CancellationToken cancellationToken)
    {
        var invoiceItemDetail = await _invoiceReadOnlyRepository.GetInvoiceItemByIdWithDetailAsync(request.Id);

        var invoiceItemDetailDto = new InvoiceItemDetailDto();
        invoiceItemDetailDto.Id = invoiceItemDetail.Id;
        invoiceItemDetailDto.OrdinalNumber = invoiceItemDetail.OrdinalNumber;
        invoiceItemDetailDto.ProductId = invoiceItemDetail.ProductId;
        invoiceItemDetailDto.Product = invoiceItemDetail.Product.Name;
        invoiceItemDetailDto.Quantity = invoiceItemDetail.Quantity;
        invoiceItemDetailDto.Price = invoiceItemDetail.Price;
        invoiceItemDetailDto.Net = invoiceItemDetail.Net;
        invoiceItemDetailDto.Gross = invoiceItemDetail.Gross;
        invoiceItemDetailDto.CurrencyId = invoiceItemDetail.CurrencyId;
        invoiceItemDetailDto.Currency = invoiceItemDetail.Currency.Symbol;
        invoiceItemDetailDto.VatRateId = invoiceItemDetail.VatRateId;
        invoiceItemDetailDto.VatRate = invoiceItemDetail.VatRate.Symbol;

        return invoiceItemDetailDto;
    }
}
