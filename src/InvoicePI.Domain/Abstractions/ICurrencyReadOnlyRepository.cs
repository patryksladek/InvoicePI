using InvoicePI.Domain.Entities.Definitions;

namespace InvoicePI.Domain.Abstractions;

public interface ICurrencyReadOnlyRepository
{
    public IQueryable<Currency> GetAllAsync();
}

