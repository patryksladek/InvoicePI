using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Entities.Customers;
using InvoicePI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace InvoicePI.Infrastructure.Repositories;

internal class CustomerReadOnlyRepository : ICustomerReadOnlyRepository
{
    private readonly InvoiceDbContext _dbContext;

    public CustomerReadOnlyRepository(InvoiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IQueryable<Customer> GetAllAsync()
    {
        return _dbContext.Customers
            .Include(x => x.Address).ThenInclude(x => x.Country)
            .Include(x => x.Contact)
            .AsNoTracking();
    }

    public async Task<Customer> GetByIdWithDetailAsync(int id, CancellationToken cancellation = default)
    {
        return await _dbContext.Customers
            .Include(x => x.Address).ThenInclude(x => x.Country)
            .Include(x => x.Contact)
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == id, cancellation);
    }
}
