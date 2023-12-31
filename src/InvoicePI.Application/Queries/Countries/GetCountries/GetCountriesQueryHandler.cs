﻿using InvoicePI.Application.Dto;
using InvoicePI.Application.Queries.Customers.GetCustomers;
using InvoicePI.Domain.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace InvoicePI.Application.Queries.Countries.GetCountries;

internal class GetCountriesQueryHandler : IRequestHandler<GetCountriesQuery, IReadOnlyCollection<CountryDto>>
{
    private readonly ICountryReadOnlyRepository _countryReadOnlyRepository;

    public GetCountriesQueryHandler(ICountryReadOnlyRepository countryReadOnlyRepository)
    {
        _countryReadOnlyRepository = countryReadOnlyRepository;
    }

    public async Task<IReadOnlyCollection<CountryDto>> Handle(GetCountriesQuery request, CancellationToken cancellationToken)
    {
        var countries = _countryReadOnlyRepository.GetAllAsync();

        var countriesDto = await countries.Select(x => new CountryDto()
        {
            Id = x.Id,
            Symbol = x.Symbol,
            Name = x.Name
        })
        .ToListAsync();

        return countriesDto;
    }
}
