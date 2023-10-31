using System.Xml.Linq;

namespace InvoicePI.Domain.Exceptions;

public class CustomerWithSameCodeAlreadyExistsException : Exception
{
    public string Code { get; set; }
    public CustomerWithSameCodeAlreadyExistsException(string code)
        : base($"Customer with code {code} already exists.")
        => Code = code;
}