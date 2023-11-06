namespace InvoicePI.Domain.Exceptions;

public class ProductWithSameCodeAlreadyExistsException : Exception
{
    public string Code { get; set; }
    public ProductWithSameCodeAlreadyExistsException(string code)
        : base($"Product with code {code} already exists.")
        => Code = code;
}