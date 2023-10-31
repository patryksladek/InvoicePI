using MediatR;

namespace InvoicePI.Application.Commands.Invoices.RemoveInvoice;

public record RemoveInvoiceCommand(int Id) : IRequest;
