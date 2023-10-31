using InvoicePI.Application.Dto;
using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace InvoicePI.Application.Queries.Invoices.GetProducts;

public class GetInvoicesQueryHandler : IRequestHandler<GetInvoicesQuery, IReadOnlyCollection<InvoiceDto>>
{
    private readonly IInvoiceReadOnlyRepository _invoiceReadOnlyRepository;

    public GetInvoicesQueryHandler(IInvoiceReadOnlyRepository invoiceReadOnlyRepository)
    {
        _invoiceReadOnlyRepository = invoiceReadOnlyRepository;
    }

    public async Task<IReadOnlyCollection<InvoiceDto>> Handle(GetInvoicesQuery request, CancellationToken cancellationToken)
    {
        var invoices = _invoiceReadOnlyRepository.GetAllAsync();

        var invoicesDto = await invoices.Select(x => new InvoiceDto()
        {
            Id = x.Id,
            IsApproved = x.Status == InvoiceStatus.Confirmed ? true : false,
            Number = x.Number,
            Date = x.Date,
            Customer = $"{x.Customer.Name} ({x.Customer.Code})",
            Net = x.Net,
            Vat = x.Vat,
            Gross = x.Gross,
            Currency = x.Currency.Symbol,
            InvoiceItems = x.InvoiceItems.Select(x => new InvoiceItemDto()
            {
                Product = x.Product.Name,
                Quantity = x.Quantity,
                Net = x.Net,
                Vat = x.Vat,
                Gross = x.Gross,
                Currency = x.Currency.Symbol
            })
        })
        .ToListAsync();

        return invoicesDto;
    }
}
