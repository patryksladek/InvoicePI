using InvoicePI.Application.Dto;
using MediatR;

namespace InvoicePI.Application.Queries.Customers.GetCustomerById;

public record GetCustomerByIdQuery(int Id) : IRequest<CustomerDetailDto>;
