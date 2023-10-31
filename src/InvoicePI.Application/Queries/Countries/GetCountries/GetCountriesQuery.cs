using InvoicePI.Application.Dto;
using MediatR;

namespace InvoicePI.Application.Queries.Countries.GetCountries;

public record GetCountriesQuery : IRequest<IReadOnlyCollection<CountryDto>>;
