﻿using InvoicePI.Application.Dto;
using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Enums;
using MediatR;
using System.Security.Cryptography.X509Certificates;

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
        invoiceDto.InvoiceItems = invoice.InvoiceItems.Select(x => new InvoiceItemDetailDto()
        {
            Id = x.Id,
            OrdinalNumber = x.OrdinalNumber,
            ProductId = x.ProductId,
            Product = x.Product.Name,
            Quantity = x.Quantity,
            Price = x.Price,
            Net = x.Net,
            Gross = x.Gross,
            CurrencyId = x.CurrencyId,
            Currency = x.Currency.Symbol,
            VatRateId = x.VatRateId,
            VatRate = x.VatRate.Symbol,
        });

        return invoiceDto;
    }
}
