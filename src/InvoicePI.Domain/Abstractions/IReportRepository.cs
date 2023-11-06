using InvoicePI.Domain.Classes;
using InvoicePI.Domain.Entities.Customers;

namespace InvoicePI.Domain.Abstractions;

public interface IReportRepository
{
    public Task<Customer> GetCustomersInvoicesAsync(int customerId);
    public Task<IOrderedEnumerable<InvoiceMonthlySummaries>> GetInvoiceMonthlySummariesAsync();
    public Task<Dictionary<string, int>> GetNumberOfCustomersInCountryAsync();
}
