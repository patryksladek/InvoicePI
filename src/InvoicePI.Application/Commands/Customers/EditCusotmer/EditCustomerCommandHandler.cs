using InvoicePI.Application.Commands.Customers.AddCustomer;
using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Entities;
using InvoicePI.Domain.Enums;
using InvoicePI.Domain.Exceptions;
using MediatR;

namespace InvoicePI.Application.Commands.Customers.EditCusotmer;

internal class EditCustomerCommandHandler : IRequestHandler<EditCustomerCommand>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IUnitOfWork _unitOfWork;

    public EditCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
    {
        _customerRepository = customerRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(EditCustomerCommand request, CancellationToken cancellationToken)
    {
        var customer = await _customerRepository.GetByIdAsync(request.Id, cancellationToken);
        if (customer == null)
            throw new CustomerNotFoundException(request.Id);

        bool isAlreadyExistWithSameName = await _customerRepository.IsAlreadyExistWithSameNameAsync(request.Id, request.Name, cancellationToken);
        if (isAlreadyExistWithSameName)
            throw new CustomerWithSameNameAlreadyExistsException(request.Name);

        if (!request.Code.Equals("?"))
        {
            bool isAlreadyExistWithSameCode = await _customerRepository.IsAlreadyExistWithSameCodeAsync(request.Id, request.Code, cancellationToken);
            if (isAlreadyExistWithSameCode)
                throw new CustomerWithSameCodeAlreadyExistsException(request.Code);
        }

        customer.Name = request.Name;
        customer.Code = request.Code;
        customer.NIP = request.NIP;
        customer.Segment = request.Segment.HasValue ? (CustomerSegment)request.Segment.Value : null;
        customer.IsActive = request.IsActive;
        customer.Address.Street = request.Street;
        customer.Address.StreetNumber = request.StreetNumber;
        customer.Address.Building = request.Building;
        customer.Address.PostalCode = request.PostalCode;
        customer.Address.City = request.City;
        customer.Address.CountryId = request.CountryId;
        customer.Contact.Phone = request.Phone;
        customer.Contact.Mobile = request.Mobile;
        customer.Contact.Email = request.Email;
        customer.Contact.Fax = request.Fax;

        _customerRepository.Update(customer);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
