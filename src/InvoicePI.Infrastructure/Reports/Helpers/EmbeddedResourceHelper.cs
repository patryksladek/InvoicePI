﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
