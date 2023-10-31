﻿using InvoicePI.Application.Dto;
using MediatR;

namespace InvoicePI.Application.Commands.Customers.AddCustomer;

public class AddCustomerCommand : IRequest<CustomerDetailDto>
{
    public string Name { get; set; }
    public string Code { get; set; }
    public string NIP { get; set; }
    public int? Segment { get; set; }
    public bool IsActive { get; set; }
    public string Street { get; set; }
    public string StreetNumber { get; set; }
    public string Building { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public int CountryId { get; set; }
    public string Phone { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
    public string Fax { get; set; }
}