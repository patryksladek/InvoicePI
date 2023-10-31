using Bogus;
using InvoicePI.Domain.Entities.Customers;
using InvoicePI.Domain.Enums;
using InvoicePI.Infrastructure.Context;

namespace InvoicePI.Infrastructure.DataGeneration.Generators;

public class CustomersGenerator 
{
    private static InvoiceDbContext _dbContext;

    public CustomersGenerator(InvoiceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Customer> Generate(int count)
    {
        var customers = GenerateCustomers(count);

        foreach (var customer in customers)
            _dbContext.Customers.AddRange(customers);

        _dbContext.SaveChanges();

        return customers;
    }

    private static List<Customer> GenerateCustomers(int count)
    {
        var customerFaker = new Faker<Customer>()
            .RuleFor(c => c.Name, f => f.Person.FullName)
            .RuleFor(c => c.Code, f => f.Random.Number(0, 99999).ToString("D5"))
            .RuleFor(c => c.NIP, f => f.Random.Replace("##########"))
            .RuleFor(c => c.Segment, f => f.PickRandom<CustomerSegment>())
            .RuleFor(c => c.Address, f => GenerateAddress(f))
            .RuleFor(c => c.Contact, f => GenerateContact(f))
            .RuleFor(c => c.IsActive, f => f.Random.Bool());

        return customerFaker.Generate(count);
    }
    private static Address GenerateAddress(Faker faker)
    {
        return new Address
        {
            Street = faker.Address.StreetName(),
            StreetNumber = faker.Address.BuildingNumber(),
            City = faker.Address.City(),
            PostalCode = faker.Address.ZipCode(),
            CountryId = faker.Random.Number(1, 242),
        };
    }
    private static Contact GenerateContact(Faker faker)
    {
        return new Contact
        {
            Phone = faker.Phone.PhoneNumber(),
            Mobile = faker.Phone.PhoneNumber(),
            Email = faker.Internet.Email(),
        };
    }
}
