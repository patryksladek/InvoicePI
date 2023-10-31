using InvoicePI.Domain.Entities.Customers;

namespace InvoicePI.Domain.Abstractions;

public interface ICustomerRepository
{
    Task<Customer> GetByIdAsync(int id, CancellationToken cancellation = default);
    Task<string> GetNextCustomerCodeAsync(CancellationToken cancellation = default);
    Task<bool> IsAlreadyExistWithSameNameAsync(string name, CancellationToken cancellation = default);
    Task<bool> IsAlreadyExistWithSameNameAsync(int id, string name, CancellationToken cancellation = default);
    Task<bool> IsAlreadyExistWithSameCodeAsync(string code, CancellationToken cancellation = default);
    Task<bool> IsAlreadyExistWithSameCodeAsync(int id, string code, CancellationToken cancellation = default);
    void Add(Customer customer);
    void Update(Customer customer);
    void Delete(Customer customer);
}
