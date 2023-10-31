using InvoicePI.Domain.Entities.Products;

namespace InvoicePI.Domain.Abstractions;

public interface IUnitReadOnlyRepository
{
    public IQueryable<Unit> GetAllAsync();
}
