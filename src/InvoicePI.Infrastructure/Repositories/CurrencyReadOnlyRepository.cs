using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Entities.Definitions;
using InvoicePI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace InvoicePI.Infrastructure.Repositories;

internal class CurrencyReadOnlyRepository : ICurrencyReadOnlyRepository
{
    private readonly InvoiceDbContext _dbContext;

    public CurrencyReadOnlyRepository(InvoiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<Currency> GetAllAsync()
    {
        return _dbContext.Currencies.AsNoTracking();
    }
}