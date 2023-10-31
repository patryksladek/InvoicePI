using Bogus;
using InvoicePI.Domain.Entities.Customers;
using InvoicePI.Domain.Entities.Invoices;
using InvoicePI.Domain.Entities.Products;
using InvoicePI.Domain.Enums;
using InvoicePI.Infrastructure.Context;
using System.Collections.Generic;

namespace InvoicePI.Infrastructure.DataGeneration.Generators;

public class InvoicesGenerator
{
    private static InvoiceDbContext _dbContext;

    public InvoicesGenerator(InvoiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Invoice> Generate(int count, List<Customer> customers, List<Product> products)
    {
        var invoices = GenerateInvoices(count, customers, products);

        foreach (var invoice in invoices)
            _dbContext.Invoices.AddRange(invoice);

        _dbContext.SaveChanges();

        return invoices;
    }

    private static List<Invoice> GenerateInvoices(int count, List<Customer> customers, List<Product> products)
    {
        var invoiceFaker = new Faker<Invoice>()
            .RuleFor(i => i.Number, f => "FV/" + f.Random.Number(0, 99999).ToString("D5") + "/23")
            .RuleFor(i => i.Date, f => DateOnly.FromDateTime(f.Date.Recent(200)))
            .RuleFor(i => i.CustomerId, f => f.PickRandom(customers).Id)
            .RuleFor(i => i.CurrencyId, f => f.PickRandom(products).CurrencyId)
            .RuleFor(i => i.Status, f => f.PickRandom<InvoiceStatus>());

        var invoices = invoiceFaker.Generate(count);

        foreach (var invoice in invoices)
        {
            invoice.InvoiceItems = GenerateInvoiceItems(new Random().Next(1, 10), invoice, products);
            invoice.Net = invoice.InvoiceItems.Sum(x => x.Net);
            invoice.Vat = invoice.InvoiceItems.Sum(x => x.Net);
            invoice.Gross = invoice.InvoiceItems.Sum(x => x.Net);
        }

        return invoices;
    }

    private static List<InvoiceItem> GenerateInvoiceItems(int count, Invoice invoice, List<Product> products)
    {
        var vatRates = _dbContext.VatRates;

        var itemFaker = new Faker<InvoiceItem>()
            .RuleFor(ii => ii.InvoiceId, invoice.Id)
            .RuleFor(ii => ii.ProductId, f => f.PickRandom(products).Id)
            .RuleFor(ii => ii.Quantity, f => f.Random.Number(1, 10))
            .RuleFor(iI => iI.CurrencyId, invoice.CurrencyId)
            .RuleFor(ii => ii.VatRateId, f => f.PickRandom(products).VatRateId)
            .RuleFor(ii => ii.Net, f => f.Random.Decimal(10, 1000))
            .RuleFor(ii => ii.Vat, (f, ii) => ii.Net * vatRates.Single(x => x.Id == ii.VatRateId).Value)
            .RuleFor(ii => ii.Gross, (f, ii) => ii.Net + ii.Vat);

        return itemFaker.Generate(count);
    }

}
