using InvoicePI.Domain.Entities.Customers;

namespace InvoicePI.Domain.Abstractions;

public interface ICustomerReadOnlyRepository
{
    public IQueryable<Customer> GetAllAsync();
    public Task<Customer> GetByIdWithDetailAsync(int id, CancellationToken cancellation = default);
}
