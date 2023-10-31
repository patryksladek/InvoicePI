using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Entities.Products;
using InvoicePI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace InvoicePI.Infrastructure.Repositories;

internal class ProductReadOnlyRepository : IProductReadOnlyRepository
{
    private readonly InvoiceDbContext _dbContext;

    public ProductReadOnlyRepository(InvoiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<Product> GetAllAsync()
    {
        return _dbContext.Products
            .Include(x => x.Currency)
            .Include(x => x.Unit)
            .Include(x => x.VatRate)
            .AsNoTracking();
    }

    public async Task<Product> GetByIdWithDetailAsync(int id, CancellationToken cancellation = default)
    {
        return await _dbContext.Products
             .Include(x => x.Currency)
            .Include(x => x.Unit)
            .Include(x => x.VatRate)
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == id, cancellation);
    }
}
