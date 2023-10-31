using InvoicePI.Domain.Entities.Definitions;

namespace InvoicePI.Domain.Abstractions;

public interface IVatRateReadOnlyRepository
{
    public IQueryable<VatRate> GetAllAsync();
}

