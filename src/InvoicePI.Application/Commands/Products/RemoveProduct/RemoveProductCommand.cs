using MediatR;

namespace InvoicePI.Application.Commands.Customers.RemoveCustomer;

public record RemoveProductCommand(int Id) : IRequest;
