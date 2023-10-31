using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Entities.Products;
using InvoicePI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace InvoicePI.Infrastructure.Repositories;

public class UnitReadOnlyRepository : IUnitReadOnlyRepository
{
    private readonly InvoiceDbContext _dbContext;

    public UnitReadOnlyRepository(InvoiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<Unit> GetAllAsync()
    {
        return _dbContext.Units.AsNoTracking();
    }
}
