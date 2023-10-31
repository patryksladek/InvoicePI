namespace InvoicePI.Application.Validation.Constatns;


public static class CustomerValidationRuleConstans
{
    public static int MaximumNameLength => 240;
    public static int MaximumCodeLength => 20;
    public static int MaximumNipLength => 17;
    public static int MaximumStreetLength => 100;
    public static int MaximumStreetNumberLength => 50;
    public static int MaximumBuildingLength => 50;
    public static int MaximumCityLength => 100;
    public static int MaximumPostalCodeLength => 16;
    public static int MaximumPhoneLength => 30;
    public static int MaximumMobileLength => 30;
    public static int MaximumEmailLength => 100;
    public static int MaximumFaxLength => 30;
}
