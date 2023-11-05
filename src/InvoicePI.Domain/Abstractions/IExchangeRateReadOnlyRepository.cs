using InvoicePI.Domain.Entities.Definitions;

namespace InvoicePI.Domain.Abstractions;

public interface IExchangeRateReadOnlyRepository
{
    public IQueryable<ExchangeRate> GetAllAsync();
}
