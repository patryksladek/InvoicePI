﻿using InvoicePI.Domain.Entities.Invoices;

namespace InvoicePI.Domain.Abstractions;

public interface IInvoiceReadOnlyRepository
{
    public IQueryable<Invoice> GetAllAsync();
    public Task<Invoice> GetByIdWithDetailAsync(int id, CancellationToken cancellation = default);
    public Task<InvoiceItem> GetInvoiceItemByIdWithDetailAsync(int itemId, CancellationToken cancellation = default);
}
