using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Entities.Invoices;
using InvoicePI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace InvoicePI.Infrastructure.Repositories;

internal class InvoiceReadOnlyRepository : IInvoiceReadOnlyRepository
{
    private readonly InvoiceDbContext _dbContext;

    public InvoiceReadOnlyRepository(InvoiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<Invoice> GetAllAsync()
    {
        return _dbContext.Invoices
            .Include(x => x.Customer)
            .Include(x => x.Currency)
            .Include(x => x.InvoiceItems).ThenInclude(x => x.Product)
            .Include(x => x.InvoiceItems).ThenInclude(x => x.Currency)
            .AsNoTracking();
    }

    public async Task<Invoice> GetByIdWithDetailAsync(int id, CancellationToken cancellation = default)
    {
        return await _dbContext.Invoices
            .Include(x => x.Customer)
            .Include(x => x.Currency)
            .Include(x => x.InvoiceItems).ThenInclude(x => x.Product)
            .Include(x => x.InvoiceItems).ThenInclude(x => x.Currency)
            .Include(x => x.InvoiceItems).ThenInclude(x => x.VatRate)
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == id, cancellation);
    }

    public async Task<InvoiceItem> GetInvoiceItemByIdWithDetailAsync(int itemId, CancellationToken cancellation = default)
    {
        return await _dbContext.InvoiceItems
            .Include(x => x.Product)
            .Include(x => x.Currency)
            .Include(x => x.VatRate)
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == itemId, cancellation);
    }
}
