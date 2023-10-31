using InvoicePI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace InvoicePI.Infrastructure.Database;

public class DatabaseInitializer
{
    private readonly InvoiceDbContext _dbContext;

    public DatabaseInitializer(InvoiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void MigrateDatabase()
    {
        _dbContext.Database.Migrate();
    }

    public bool AnyMigrationsPending()
    {
        var pendingMigrations = _dbContext.Database.GetPendingMigrations();
        return pendingMigrations.Any();
    }
}
