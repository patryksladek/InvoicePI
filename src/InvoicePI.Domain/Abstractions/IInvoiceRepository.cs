﻿using InvoicePI.Domain.Entities.Invoices;

namespace InvoicePI.Domain.Abstractions;

public interface IInvoiceRepository
{
    Task<Invoice> GetByIdAsync(int id, CancellationToken cancellation = default);
    Task<string> GetNextInvoiceNumberAsync(CancellationToken cancellation = default);
    void Add(Invoice product);
    void Update(Invoice product);
    void Delete(Invoice product);
}
