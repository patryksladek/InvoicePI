using InvoicePI.Application.Dto;
using MediatR;

namespace InvoicePI.Application.Queries.Customers.GetCustomers;

public record GetCustomersQuery() : IRequest<IReadOnlyCollection<CustomerDto>>;