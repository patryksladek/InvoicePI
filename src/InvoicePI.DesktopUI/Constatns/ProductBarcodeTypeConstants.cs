using System;

namespace InvoicePI.DesktopUI.Constatns;

public static class ProductBarcodeTypeConstants
{
    public const string EAN13 = "EAN13";
    public const string Other = "Other";

    public static int GetValue(string productBarcodeType) =>
       productBarcodeType switch
       {
           EAN13 => 0,
           Other => 1,
           _ => throw new ArgumentException($"Value {productBarcodeType} is not supported.")
       };
}
