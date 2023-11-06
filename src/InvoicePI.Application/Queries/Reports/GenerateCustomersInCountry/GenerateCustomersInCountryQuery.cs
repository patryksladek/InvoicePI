using MediatR;

namespace InvoicePI.Application.Queries.Reports.GenerateNumberOfCustomersInCountry;

public record GenerateCustomersInCountryQuery() : IRequest<byte[]>;
