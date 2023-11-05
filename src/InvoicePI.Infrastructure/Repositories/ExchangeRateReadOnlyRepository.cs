using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Entities.Definitions;
using InvoicePI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace InvoicePI.Infrastructure.Repositories;

internal class ExchangeRateReadOnlyRepository : IExchangeRateReadOnlyRepository
{
    private readonly InvoiceDbContext _dbContext;

    public ExchangeRateReadOnlyRepository(InvoiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<ExchangeRate> GetAllAsync()
    {
        return _dbContext.ExchangeRates.AsNoTracking();
    }
}
