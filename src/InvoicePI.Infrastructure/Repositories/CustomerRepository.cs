using InvoicePI.Domain.Abstractions;
using InvoicePI.Domain.Entities.Customers;
using InvoicePI.Infrastructure.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace InvoicePI.Infrastructure.Repositories;

internal class CustomerRepository : ICustomerRepository
{
    private readonly InvoiceDbContext _dbContext;

    public CustomerRepository(InvoiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Customer> GetByIdAsync(int id, CancellationToken cancellation = default)
    {
        return await _dbContext.Customers
            .Include(x => x.Address).ThenInclude(x => x.Country)
            .Include(x => x.Contact)
            .SingleOrDefaultAsync(x => x.Id == id, cancellation);
    }

    /// <summary>
    /// This method returns the available customer code.
    /// If the last customer code is not equal to 99999, then the next available customer code is a value one greater than the last added customer code.
    /// Otherwise, we iterate through the list of customer codes until we find the first available customer code.
    /// </summary>
    /// <returns>5-character numeric string</returns>
    public async Task<string> GetNextCustomerCodeAsync(CancellationToken cancellation = default)
    {
        var existingCodes = (await _dbContext.Customers
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
        return await _dbContext.Customers.AnyAsync(x => x.Name.ToLower() == name.ToLower(), cancellation);
    }

    public async Task<bool> IsAlreadyExistWithSameNameAsync(int id, string name, CancellationToken cancellation = default)
    {
        return await _dbContext.Customers.AnyAsync(x => x.Id != id && x.Name.ToLower() == name.ToLower(), cancellation);
    }

    public async Task<bool> IsAlreadyExistWithSameCodeAsync(string code, CancellationToken cancellation = default)
    {
        return await _dbContext.Customers.AnyAsync(x => x.Code.ToLower() == code.ToLower(), cancellation);
    }

    public async Task<bool> IsAlreadyExistWithSameCodeAsync(int id, string code, CancellationToken cancellation = default)
    {
        return await _dbContext.Customers.AnyAsync(x => x.Id != id && x.Code.ToLower() == code.ToLower(), cancellation);
    }

    public void Add(Customer customer)
    {
        _dbContext.Customers.Add(customer);
    }

    public void Update(Customer customer)
    {
        _dbContext.Customers.Update(customer);
    }

    public void Delete(Customer customer)
    {
        _dbContext.Customers.Remove(customer);
    }
}
