using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Entities.Definitions;
using InvoicePI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace InvoicePI.Infrastructure.Repositories;

internal class VatRateReadOnlyRepository : IVatRateReadOnlyRepository
{
    private readonly InvoiceDbContext _dbContext;

    public VatRateReadOnlyRepository(InvoiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<VatRate> GetAllAsync()
    {
        return _dbContext.VatRates.AsNoTracking();
    }
}