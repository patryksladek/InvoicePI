using InvoicePI.Application.Dto;
using InvoicePI.Application.Queries.Customers.GetCustomers;
using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Enums;
using MediatR;

namespace InvoicePI.Application.Queries.Customers.GetCustomerById;

internal class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, CustomerDetailDto>
{
    private readonly ICustomerReadOnlyRepository _customerReadOnlyRepository;

    public GetCustomerByIdQueryHandler(ICustomerReadOnlyRepository customerReadOnlyRepository)
    {
        _customerReadOnlyRepository = customerReadOnlyRepository;
    }

    public async Task<CustomerDetailDto> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
    {
        var customer = await _customerReadOnlyRepository.GetByIdWithDetailAsync(request.Id);

        var customerDto = new CustomerDetailDto()
        {
            Id = customer.Id,
            Name = customer.Name,
            Code = customer.Code,
            NIP = customer.NIP,
            Segment = customer.Segment.ToString(),
            IsActive = customer.IsActive,
            Street = customer.Address.Street,
            StreetNumber = customer.Address.Street,
            Building = customer.Address.Building, 
            City = customer.Address.City,
            PostalCode = customer.Address.PostalCode,
            CountryId = customer.Address.CountryId,
            Phone = customer.Contact.Phone,
            Mobile = customer.Contact.Mobile,
            Email = customer.Contact.Email,
            Fax = customer.Contact.Fax,
            Invoices = customer.Invoices.Select(x => new InvoiceDto()
            {
                Id = x.Id,
                IsApproved = x.Status == InvoiceStatus.Confirmed ? true : false,
                Number = x.Number,
                Date = x.Date,
                Customer = $"{customer.Name} ({customer.Code})",
                Net = x.Net,
                Vat = x.Vat,
                Gross = x.Gross,
                Currency = x.Currency.Symbol
            })
        };

        return customerDto;
    }
}