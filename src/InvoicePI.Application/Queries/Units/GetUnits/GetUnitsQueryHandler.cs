using InvoicePI.Application.Dto;
using InvoicePI.Application.Queries.Countries.GetCountries;
using InvoicePI.Domain.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace InvoicePI.Application.Queries.Units.GetUnits;

internal class GetUnitsQueryHandler : IRequestHandler<GetUnitsQuery, IReadOnlyCollection<UnitDto>>
{
    private readonly IUnitReadOnlyRepository _unitReadOnlyRepository;

    public GetUnitsQueryHandler(IUnitReadOnlyRepository unitReadOnlyRepository)
    {
        _unitReadOnlyRepository = unitReadOnlyRepository;
    }

    public async Task<IReadOnlyCollection<UnitDto>> Handle(GetUnitsQuery request, CancellationToken cancellationToken)
    {
        var units = _unitReadOnlyRepository.GetAllAsync();

        var unitsDto = await units.Select(x => new UnitDto()
        {
            Id = x.Id,
            Code = x.Code
        })
        .ToListAsync();

        return unitsDto;
    }
}
