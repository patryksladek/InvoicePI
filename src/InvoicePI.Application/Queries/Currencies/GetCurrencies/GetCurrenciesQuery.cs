using InvoicePI.Application.Dto;
using MediatR;

namespace InvoicePI.Application.Queries.VatRates.GetVatRates;

public record GetCurrenciesQuery : IRequest<IReadOnlyCollection<CurrencyDto>>;
