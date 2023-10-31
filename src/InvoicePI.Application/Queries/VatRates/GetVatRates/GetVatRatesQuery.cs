using InvoicePI.Application.Dto;
using MediatR;

namespace InvoicePI.Application.Queries.VatRates.GetVatRates;

public record GetVatRatesQuery : IRequest<IReadOnlyCollection<VatRateDto>>;
