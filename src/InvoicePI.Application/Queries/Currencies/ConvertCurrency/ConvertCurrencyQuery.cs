using MediatR;

namespace InvoicePI.Application.Queries.Currencies.ConvertCurrency;

public record ConvertCurrencyQuery(string FromCurrencySymbol, string ToCurrencySymbol, DateTime Date, int Amount = 1) : IRequest<decimal>;