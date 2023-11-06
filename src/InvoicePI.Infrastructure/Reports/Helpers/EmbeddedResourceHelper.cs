using System.Reflection;

namespace InvoicePI.Infrastructure.Reports.Helpers;

public static class EmbeddedResourceHelper
{
    public static string GetResourceAsString(Assembly assembly, string path)
    {
        string result;

        using (var stream = assembly.GetManifestResourceStream(path))
        using (var reader = new StreamReader(stream))
        {
            result = reader.ReadToEnd();
        }

        return result;
    }
}
