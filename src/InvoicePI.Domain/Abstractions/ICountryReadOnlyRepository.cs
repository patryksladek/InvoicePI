using InvoicePI.Domain.Entities.Customers;

namespace InvoicePI.Domain.Abstractions;

public interface ICountryReadOnlyRepository
{
    public IQueryable<Country> GetAllAsync();
}
