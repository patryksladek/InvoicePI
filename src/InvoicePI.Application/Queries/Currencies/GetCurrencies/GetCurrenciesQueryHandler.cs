using InvoicePI.Application.Dto;
using InvoicePI.Domain.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace InvoicePI.Application.Queries.VatRates.GetVatRates;

internal class GetCurrenciesQueryHandler : IRequestHandler<GetCurrenciesQuery, IReadOnlyCollection<CurrencyDto>>
{
    private readonly ICurrencyReadOnlyRepository _currencyReadOnlyRepository;

    public GetCurrenciesQueryHandler(ICurrencyReadOnlyRepository currencyReadOnlyRepository)
    {
        _currencyReadOnlyRepository = currencyReadOnlyRepository;
    }

    public async Task<IReadOnlyCollection<CurrencyDto>> Handle(GetCurrenciesQuery request, CancellationToken cancellationToken)
    {
        var currencies = _currencyReadOnlyRepository.GetAllAsync();

        var currenciesDto = await currencies.Select(x => new CurrencyDto()
        {
            Id = x.Id,
            Symbol = x.Symbol
        })
        .ToListAsync();

        return currenciesDto;
    }
}
