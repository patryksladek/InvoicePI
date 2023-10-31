using MediatR;

namespace InvoicePI.Application.Commands.Customers.RemoveCustomer;

public record RemoveCustomerCommand(int Id) : IRequest;
