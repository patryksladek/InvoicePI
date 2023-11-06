namespace InvoicePI.DesktopUI.Constatns;

public static class SegmentConstans
{
    public const string Corporate = "Corporate";
    public const string Consumer = "Consumer";
    public const string HomeOffice = "Home Office";
    public const string SmallBusiness = "Small Business";

    public static int? GetValue(string segment) =>
       segment switch
       {
           Corporate => 0,
           Consumer => 1,
           HomeOffice => 2,
           SmallBusiness => 3,
           _ => null
       };
}


