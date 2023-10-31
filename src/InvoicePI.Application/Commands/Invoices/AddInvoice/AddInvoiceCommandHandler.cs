using InvoicePI.Application.Dto;
using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Entities.Invoices;
using InvoicePI.Domain.Entities.Products;
using InvoicePI.Domain.Enums;
using InvoicePI.Domain.Exceptions;
using MediatR;

namespace InvoicePI.Application.Commands.Invoices.AddInvoice;

internal class AddInvoiceCommandHandler : IRequestHandler<AddInvoiceCommand, InvoiceDetailDto>
{
    private readonly IInvoiceRepository _invoiceRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AddInvoiceCommandHandler(IInvoiceRepository invoiceRepository, IUnitOfWork unitOfWork)
    {
        _invoiceRepository = invoiceRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<InvoiceDetailDto> Handle(AddInvoiceCommand request, CancellationToken cancellationToken)
    {
        var newInvoice = new Invoice()
        {
            Number = await _invoiceRepository.GetNextInvoiceNumberAsync(),
            Date = request.Date,
            CustomerId = request.CustomerId,
            Description = request.Description,
            Net = request.Net,
            Vat = request.Vat,
            Gross = request.Gross,
            InvoiceItems = new List<InvoiceItem>()
        };

        foreach (var invoiceItem in request.InvoiceItems)
        {
            newInvoice.InvoiceItems.Add(new InvoiceItem()
            {
                ProductId = invoiceItem.ProductId,
                Quantity = invoiceItem.Quantity,
                Net = invoiceItem.Net,
                Vat = invoiceItem.Vat,
                Gross = invoiceItem.Gross,
                CurrencyId = invoiceItem.CurrencyId,
                VatRateId = invoiceItem.VatRateId
            });
        }

        _invoiceRepository.Add(newInvoice);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var invoiceDetailDto = new InvoiceDetailDto()
        {
            Number = request.Number,
            Date = request.Date,
            CustomerId = request.CustomerId,
            Description = request.Description,
            Net = request.Net,
            Vat = request.Vat,
            Gross = request.Gross,
        };

        return invoiceDetailDto;
    }
}
