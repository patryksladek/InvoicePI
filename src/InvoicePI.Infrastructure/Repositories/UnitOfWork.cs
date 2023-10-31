using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Entities;
using InvoicePI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace InvoicePI.Infrastructure.Repositories;

internal class UnitOfWork : IUnitOfWork
{
    private readonly InvoiceDbContext _dbContext;

    public UnitOfWork(InvoiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        UpdateAuditableEntities();
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    private void UpdateAuditableEntities()
    {
        var entries = _dbContext
            .ChangeTracker
            .Entries<AuditableEntity>();

        foreach (var entry in entries)
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedAt = entry.Entity.UpdatedAt = DateTime.Now;
            }

            if (entry.State == EntityState.Modified)
            {
                entry.Entity.UpdatedAt = DateTime.Now;
            }
        }
    }
}
