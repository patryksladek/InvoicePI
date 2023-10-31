using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Entities.Products;
using InvoicePI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace InvoicePI.Infrastructure.Repositories;

internal class ProductRepository : IProductRepository
{
    private readonly InvoiceDbContext _dbContext;

    public ProductRepository(InvoiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Product> GetByIdAsync(int id, CancellationToken cancellation = default)
    {
        return await _dbContext.Products
            .Include(x => x.Unit)
            .Include(x => x.VatRate)
            .SingleOrDefaultAsync(x => x.Id == id, cancellation);
    }

    /// <summary>
    /// This method returns the available customer code.
    /// If the last product code is not equal to 99999, then the next available product code is a value one greater than the last added product code.
    /// Otherwise, we iterate through the list of product codes until we find the first available product code.
    /// </summary>
    /// <returns>5-character numeric string</returns>
    public async Task<string> GetNextProductCodeAsync(CancellationToken cancellation = default)
    {
        var existingCodes = (await _dbContext.Products
            .Select(x => x.Code)
            .ToListAsync(cancellation))
            .Where(code => Regex.IsMatch(code, @"^\d{1,5}$"))
            .OrderBy(code => code);

        int nextId = 1;

        if (!existingCodes.Any())
        {
            nextId = 1;
        }
        else if (existingCodes.Last() != "99999")
        {
            nextId = int.Parse(existingCodes.Last()) + 1;
        }
        else
        {
            foreach (string code in existingCodes)
            {
                if (int.Parse(code) == nextId)
                    nextId++;
                else
                    break;
            }
        }

        return nextId.ToString("D5");
    }

    public async Task<bool> IsAlreadyExistWithSameNameAsync(string name, CancellationToken cancellation = default)
    {
        return await _dbContext.Products.AnyAsync(x => x.Name.ToLower() == name.ToLower(), cancellation);
    }

    public async Task<bool> IsAlreadyExistWithSameNameAsync(int id, string name, CancellationToken cancellation = default)
    {
        return await _dbContext.Products.AnyAsync(x => x.Id != id && x.Name.ToLower() == name.ToLower(), cancellation);
    }

    public async Task<bool> IsAlreadyExistWithSameCodeAsync(string code, CancellationToken cancellation = default)
    {
        return await _dbContext.Products.AnyAsync(x => x.Code.ToLower() == code.ToLower(), cancellation);
    }

    public async Task<bool> IsAlreadyExistWithSameCodeAsync(int id, string code, CancellationToken cancellation = default)
    {
        return await _dbContext.Products.AnyAsync(x => x.Id != id && x.Code.ToLower() == code.ToLower(), cancellation);
    }

    public void Add(Product product)
    {
        _dbContext.Products.Add(product);
    }

    public void Update(Product product)
    {
        _dbContext.Products.Update(product);
    }

    public void Delete(Product product)
    {
        _dbContext.Products.Remove(product);
    }
}
