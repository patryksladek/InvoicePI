namespace InvoicePI.Application.Dto;

public class CustomerDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public string NIP { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
        return $"{Id} | {Name} | {Code} | {NIP} | {Address} | {City} | {Country} | {Phone} | {Email}";
    }
}
