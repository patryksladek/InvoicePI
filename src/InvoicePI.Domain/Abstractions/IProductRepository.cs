using InvoicePI.Domain.Entities.Customers;
using InvoicePI.Domain.Entities.Products;

namespace InvoicePI.Domain.Abstractions;

public interface IProductRepository
{
    Task<Product> GetByIdAsync(int id, CancellationToken cancellation = default);
    Task<string> GetNextProductCodeAsync(CancellationToken cancellation = default);
    Task<bool> IsAlreadyExistWithSameNameAsync(string name, CancellationToken cancellation = default);
    Task<bool> IsAlreadyExistWithSameNameAsync(int id, string name, CancellationToken cancellation = default);
    Task<bool> IsAlreadyExistWithSameCodeAsync(string code, CancellationToken cancellation = default);
    Task<bool> IsAlreadyExistWithSameCodeAsync(int id, string code, CancellationToken cancellation = default);
    void Add(Product product);
    void Update(Product product);
    void Delete(Product product);
}
