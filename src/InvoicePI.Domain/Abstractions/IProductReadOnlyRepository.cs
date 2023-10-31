using InvoicePI.Domain.Entities.Products;

namespace InvoicePI.Domain.Abstractions;

public interface IProductReadOnlyRepository
{
    public IQueryable<Product> GetAllAsync();
    public Task<Product> GetByIdWithDetailAsync(int id, CancellationToken cancellation = default);
}
