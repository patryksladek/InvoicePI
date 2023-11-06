using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Classes;
using InvoicePI.Domain.Entities.Customers;
using InvoicePI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace InvoicePI.Infrastructure.Repositories;

internal class ReportRepository : IReportRepository
{
    private readonly InvoiceDbContext _dbContext;

    public ReportRepository(InvoiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Customer> GetCustomersInvoicesAsync(int customerId)
    {
        var customerInvoices = await _dbContext.Customers
            .Include(x => x.Invoices).ThenInclude(x => x.Currency)
            .SingleOrDefaultAsync(x => x.Id == customerId);

        return customerInvoices;
    }

    public async Task<Dictionary<string, int>> GetNumberOfCustomersInCountryAsync()
    {
        var customersInCountries = await _dbContext.Customers
            .Join(_dbContext.Addresses, c => c.Id, a => a.CustomerId, (customer, address) => new { customer, address })
            .Join(_dbContext.Countries, ca => ca.address.CountryId, country => country.Id, (ca, country) => new { ca.customer, country })
            .GroupBy(c => c.country.Name)
            .Select(g => new
            {
                Country = g.Key,
                NumberOfCustomers = g.Count()
            })
            .OrderBy(c => c.Country)
            .ToDictionaryAsync(entry => entry.Country, entry => entry.NumberOfCustomers);

        return customersInCountries;
    }

    public async Task<IOrderedEnumerable<InvoiceMonthlySummaries>> GetInvoiceMonthlySummariesAsync()
    {
        var summaries = (await _dbContext.Invoices
        .Join(
            _dbContext.Currencies,
            invoice => invoice.CurrencyId,
            currency => currency.Id,
            (invoice, currency) => new { Invoice = invoice, Currency = currency }
        )
        .ToListAsync())
        .GroupBy(
            x => new
            {
                Month = x.Invoice.Date.Month,
                Year = x.Invoice.Date.Year,
                Currency = x.Currency.Symbol
            }
        )
        .Select(group => new InvoiceMonthlySummaries
        {
            Month = group.Key.Month,
            Year = group.Key.Year,
            Net = group.Sum(x => x.Invoice.Net),
            Vat = group.Sum(x => x.Invoice.Vat),
            Gross = group.Sum(x => x.Invoice.Gross),
            Currency = group.Key.Currency,
        })
        .OrderBy(summary => summary.Year)
        .ThenBy(summary => summary.Month);

        return summaries;
    }

}
