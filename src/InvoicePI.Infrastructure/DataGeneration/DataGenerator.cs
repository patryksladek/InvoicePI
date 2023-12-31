﻿using InvoicePI.Infrastructure.Context;
using InvoicePI.Infrastructure.DataGeneration.Generators;
using MediatR;

namespace InvoicePI.Infrastructure.DataGeneration;

public class DataGenerator
{
    private static InvoiceDbContext _dbContext;
    private static IMediator _mediator;

    public DataGenerator(InvoiceDbContext dbContext, IMediator mediator)
    {
        _dbContext = dbContext;
        _mediator = mediator;
    }

    public bool IsNoData()
        => _dbContext.Customers.Count() == 0 && _dbContext.Products.Count() == 0 && _dbContext.Invoices.Count() == 0;
    
    public void GenerateData(int customersCount, int productsCount, int invoicesCount)
    {
        var customers = new CustomersGenerator(_dbContext).Generate(customersCount);
        var products = new ProductsGenerator(_dbContext).Generate(productsCount);
        new InvoicesGenerator(_dbContext,_mediator).Generate(invoicesCount, customers, products);
    }
}
