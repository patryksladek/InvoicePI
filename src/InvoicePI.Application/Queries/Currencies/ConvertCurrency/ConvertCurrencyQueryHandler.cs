using InvoicePI.Domain.Abstractions;
using MediatR;

namespace InvoicePI.Application.Queries.Currencies.ConvertCurrency;

internal class ConvertCurrencyQueryHandler : IRequestHandler<ConvertCurrencyQuery, decimal>
{
    private readonly ICurrencyConverter _currencyConverter;

    public ConvertCurrencyQueryHandler(ICurrencyConverter currencyConverter)
    {
        _currencyConverter = currencyConverter;
    }
    public Task<decimal> Handle(ConvertCurrencyQuery request, CancellationToken cancellationToken)
    {
        decimal value = _currencyConverter.Convert(request.Amount, request.FromCurrencySymbol, request.ToCurrencySymbol, request.Date);
        return Task.FromResult(value);
    }
}
