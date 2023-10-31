using Bogus;
using InvoicePI.Domain.Entities.Products;
using InvoicePI.Domain.Enums;
using InvoicePI.Infrastructure.Context;

namespace InvoicePI.Infrastructure.DataGeneration.Generators;

public class ProductsGenerator
{
    private static InvoiceDbContext _dbContext;

    public ProductsGenerator(InvoiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Product> Generate(int count)
    {
        var products = GenerateProducts(count);

        foreach (var product in products)
            _dbContext.Products.AddRange(product);

        _dbContext.SaveChanges();

        return products;
    }

    private static List<Product> GenerateProducts(int count)
    {
        var productFaker = new Faker<Product>()
            .RuleFor(p => p.Name, f => f.Commerce.ProductName())
            .RuleFor(p => p.Code, f => f.Random.Number(0, 99999).ToString("D5"))
            .RuleFor(p => p.Type, f => f.PickRandom<ProductType>())
            .RuleFor(p => p.Barcode, f => f.Commerce.Ean13())
            .RuleFor(p => p.BarcodeType, f => f.PickRandom<ProductBarcodeType>())
            .RuleFor(p => p.NetPrice, f => f.Random.Decimal(10, 1000))
            .RuleFor(i => i.CurrencyId, f => f.Random.Int(1, 3))
            .RuleFor(i => i.UnitId, f => f.Random.Int(1, 3))
            .RuleFor(i => i.VatRateId, f => f.Random.Int(1, 9));

        return productFaker.Generate(count);
    }
}
