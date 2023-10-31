using InvoicePI.Application.Dto;
using MediatR;

namespace InvoicePI.Application.Queries.Units.GetUnits;

public record GetUnitsQuery : IRequest<IReadOnlyCollection<UnitDto>>;