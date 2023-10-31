using InvoicePI.DesktopUI.Constatns;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System.IO;

namespace InvoicePI.DesktopUI.Settings;

public class SettingsManager 
{
    private IConfiguration _configuration;

    private string Server => _configuration[$"{AppSettingsConstans.ConnectionStringSettings}:{AppSettingsConstans.Server}"];
    private string Database => _configuration[$"{AppSettingsConstans.ConnectionStringSettings}:{AppSettingsConstans.Database}"];
    private bool IntegratedLogin => bool.Parse(_configuration[$"{AppSettingsConstans.ConnectionStringSettings}:{AppSettingsConstans.IntegratedLogin}"]);
    private string User => _configuration[$"{AppSettingsConstans.ConnectionStringSettings}:{AppSettingsConstans.User}"];
    private string Password => _configuration[$"{AppSettingsConstans.ConnectionStringSettings}:{AppSettingsConstans.Password}"];

    public SettingsManager(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public bool IsConnectionStringInitialized()
     => !string.IsNullOrEmpty(Server) && !string.IsNullOrEmpty(Database);

    public string GetConnectionString()
    {
        if (IntegratedLogin)
            return $"Server={Server};Initial Catalog={Database};Integrated Security=True;TrustServerCertificate=True";
        else
            return $"Server={Server};Initial Catalog={Database};User Id={User};Password={Password};TrustServerCertificate=True;";
    }

    public void SetConnectionStringSettings(string server, string authentication, string user, string password)
    {
        string filePath = "appsettings.json";
        string json = File.ReadAllText(filePath);
        JObject appSettings = JObject.Parse(json);

        appSettings[AppSettingsConstans.ConnectionStringSettings][AppSettingsConstans.Server] = server;
        appSettings[AppSettingsConstans.ConnectionStringSettings][AppSettingsConstans.Database] = AppSettingsConstans.DatabaseName;
        appSettings[AppSettingsConstans.ConnectionStringSettings][AppSettingsConstans.IntegratedLogin] = authentication == AuthenticationConstants.Windows ? true : false;
        appSettings[AppSettingsConstans.ConnectionStringSettings][AppSettingsConstans.User] = user;
        appSettings[AppSettingsConstans.ConnectionStringSettings][AppSettingsConstans.Password] = password;

        File.WriteAllText(filePath, appSettings.ToString());

        _configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
    }


}
