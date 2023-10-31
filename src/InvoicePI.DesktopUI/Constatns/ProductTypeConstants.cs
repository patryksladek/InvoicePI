using System;

namespace InvoicePI.DesktopUI.Constatns;

public static class ProductTypeConstants
{
    public const string Product = "Product";
    public const string Service = "Service";

    public static int GetValue(string productType) =>
       productType switch
       {
           Product => 0,
           Service => 1,
           _ => throw new ArgumentException($"Value {productType} is not supported.")
       };
}
