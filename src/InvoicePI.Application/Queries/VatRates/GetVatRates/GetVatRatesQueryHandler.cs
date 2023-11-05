using InvoicePI.Application.Dto;
using InvoicePI.Application.Queries.Units.GetUnits;
using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Entities.Definitions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace InvoicePI.Application.Queries.VatRates.GetVatRates;

internal class GetVatRatesQueryHandler : IRequestHandler<GetVatRatesQuery, IReadOnlyCollection<VatRateDto>>
{
    private readonly IVatRateReadOnlyRepository _vatRateReadOnlyRepository;

    public GetVatRatesQueryHandler(IVatRateReadOnlyRepository unitReadOnlyRepository)
    {
        _vatRateReadOnlyRepository = unitReadOnlyRepository;
    }

    public async Task<IReadOnlyCollection<VatRateDto>> Handle(GetVatRatesQuery request, CancellationToken cancellationToken)
    {
        var vatRates = _vatRateReadOnlyRepository.GetAllAsync();

        var vatRatesDto = await vatRates.Select(x => new VatRateDto()
        {
            Id = x.Id,
            Symbol = x.Symbol,
            Value = x.Value
        })
        .ToListAsync();

        return vatRatesDto;
    }
}
