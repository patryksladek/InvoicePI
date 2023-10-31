using InvoicePI.Application.Dto;
using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Entities.Customers;
using InvoicePI.Domain.Enums;
using InvoicePI.Domain.Exceptions;
using MediatR;

namespace InvoicePI.Application.Commands.Customers.AddCustomer;

internal class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, CustomerDetailDto>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AddCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
    {
        _customerRepository = customerRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<CustomerDetailDto> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
    {
        bool isAlreadyExistWithSameName = await _customerRepository.IsAlreadyExistWithSameNameAsync(request.Name, cancellationToken);
        if (isAlreadyExistWithSameName)
            throw new CustomerWithSameNameAlreadyExistsException(request.Name);

        if (!request.Code.Equals("?")) 
        { 
            bool isAlreadyExistWithSameCode =  await _customerRepository.IsAlreadyExistWithSameCodeAsync(request.Code, cancellationToken);
            if (isAlreadyExistWithSameCode)
                throw new CustomerWithSameCodeAlreadyExistsException(request.Code);
        }

        string customerCode = request.Code.Equals("?") ? await _customerRepository.GetNextCustomerCodeAsync() : request.Code;

        var newCustomer = new Customer()
        {
            Name = request.Name,
            Code = customerCode,
            NIP = request.NIP,
            Segment = request.Segment.HasValue ? (CustomerSegment)request.Segment.Value : null,
            IsActive = request.IsActive,
            Address = new Address()
            {
                Street = request.Street,
                StreetNumber = request.StreetNumber,
                Building = request.Building,
                PostalCode = request.PostalCode,
                City = request.City,
                CountryId = request.CountryId,
            },
            Contact = new Contact()
            {
                Phone = request.Phone,
                Mobile = request.Mobile,
                Email = request.Email,
                Fax = request.Fax
            }
        };

        _customerRepository.Add(newCustomer);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var customerDto = new CustomerDetailDto()
        {
            Id = newCustomer.Id,
            Name = newCustomer.Name,
            Code = newCustomer.Code,
            NIP = newCustomer.NIP,
            Segment = newCustomer.Segment.ToString(),
            IsActive = newCustomer.IsActive,
            Street = newCustomer.Address.Street,
            StreetNumber = newCustomer.Address.Street,
            Building = newCustomer.Address.Building,
            City = newCustomer.Address.City,
            PostalCode = newCustomer.Address.PostalCode,
            CountryId = newCustomer.Address.CountryId,
            Phone = newCustomer.Contact.Phone,
            Mobile = newCustomer.Contact.Mobile,
            Email = newCustomer.Contact.Email,
            Fax = newCustomer.Contact.Fax
        };

        return customerDto;
    }
}
