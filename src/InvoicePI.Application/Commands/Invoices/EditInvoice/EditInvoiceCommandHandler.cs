using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Exceptions;
using MediatR;

namespace InvoicePI.Application.Commands.Invoices.EditInvoice;

internal class EditInvoiceCommandHandler : IRequestHandler<EditInvoiceCommand>
{
    private readonly IInvoiceRepository _invoiceRepository;
    private readonly IUnitOfWork _unitOfWork;

    public EditInvoiceCommandHandler(IInvoiceRepository invoiceRepository, IUnitOfWork unitOfWork)
    {
        _invoiceRepository = invoiceRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(EditInvoiceCommand request, CancellationToken cancellationToken)
    {
        var invoice = await _invoiceRepository.GetByIdAsync(request.Id, cancellationToken);
        if (invoice == null)
            throw new InvoiceNotFoundException(request.Id);

        invoice.Date = request.Date;
        invoice.CustomerId = request.CustomerId;
        invoice.Description = request.Description;
        invoice.Net = request.Net;
        invoice.Vat = request.Vat;
        invoice.Gross = request.Gross;

        foreach (var requestInvoiceItem in request.InvoiceItems)
        {
            var invoiceItem = invoice.InvoiceItems.Single(x => x.Id == requestInvoiceItem.Id);
            invoiceItem.ProductId = requestInvoiceItem.ProductId;
            invoiceItem.Quantity = requestInvoiceItem.Quantity;
            invoiceItem.Net = requestInvoiceItem.Net;
            invoiceItem.Vat = requestInvoiceItem.Vat;
            invoiceItem.Gross = requestInvoiceItem.Gross;
            invoiceItem.CurrencyId = requestInvoiceItem.CurrencyId;
            invoiceItem.VatRateId = requestInvoiceItem.VatRateId;
        }

        _invoiceRepository.Update(invoice);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
