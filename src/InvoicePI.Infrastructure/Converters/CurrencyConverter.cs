﻿using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Entities.Definitions;

namespace InvoicePI.Infrastructure.Converters;

public class CurrencyConverter : ICurrencyConverter
{
    private readonly List<Currency> _currencies;
    private readonly List<ExchangeRate> _exchangeRates;

    public CurrencyConverter(ICurrencyReadOnlyRepository currencyReadOnlyRepository,
                             IExchangeRateReadOnlyRepository exchangeRateReadOnlyRepository)
    {
        _currencies = currencyReadOnlyRepository.GetAllAsync().ToList();
        _exchangeRates = exchangeRateReadOnlyRepository.GetAllAsync().ToList();
    }

    public decimal Convert(int amount, string fromCurrencySymbol, string toCurrencySymbol, DateTime date)
    {

        var fromCurrency = _currencies.FirstOrDefault(c => c.Symbol == fromCurrencySymbol);
        var toCurrency = _currencies.FirstOrDefault(c => c.IsDefault);

        if (fromCurrency == null || toCurrency == null)
        {
            throw new InvalidOperationException("Invalid currency symbols");
        }

        if (fromCurrency.IsDefault)
        {
            return amount * 1;
        }

        var exchangeRate = _exchangeRates
            .OrderByDescending(er => er.Date)
            .FirstOrDefault(er => er.CurrencyId == fromCurrency.Id);

        if (exchangeRate == null)
        {
            throw new InvalidOperationException("Exchange rate not found for the specified date");
        }

        return amount * exchangeRate.Rate;
    }
}
