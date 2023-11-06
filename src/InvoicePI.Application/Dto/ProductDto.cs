﻿namespace InvoicePI.Application.Dto;

public class ProductDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public string Barcode { get; set; }
    public decimal Price { get; set; }
    public string Currency { get; set; }
}
