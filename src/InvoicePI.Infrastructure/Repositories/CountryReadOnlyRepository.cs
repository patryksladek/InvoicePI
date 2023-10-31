using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Entities.Customers;
using InvoicePI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace InvoicePI.Infrastructure.Repositories;

internal class CountryReadOnlyRepository : ICountryReadOnlyRepository
{
    private readonly InvoiceDbContext _dbContext;

    public CountryReadOnlyRepository(InvoiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<Country> GetAllAsync()
    {
        return _dbContext.Countries.AsNoTracking();
    }
}
