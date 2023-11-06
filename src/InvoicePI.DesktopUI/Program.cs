using InvoicePI.DesktopUI.Factories;
using InvoicePI.DesktopUI.Views;
using Microsoft.Extensions.Hosting;
using System;
using InvoicePI.Infrastructure;
using InvoicePI.Application;
using InvoicePI.DesktopUI.Handlers.Abstractions;
using WinForms = System.Windows.Forms;
using InvoicePI.DesktopUI.Handlers;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using InvoicePI.DesktopUI.Settings;

namespace InvoicePI.DesktopUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WinForms.Application.EnableVisualStyles();
            WinForms.Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json"); 

            IConfiguration configuration = builder.Build();

            var host = new HostBuilder()
              .ConfigureServices((hostContext, services) =>
              {
                  services.AddSingleton(configuration);
                  services.AddSingleton<SettingsManager>();

                  services.AddFactories();
                  services.AddViews();

                  services.AddApplication();
                  services.AddInfrastructure(configuration);
              })
              .Build();

            IHandler authenticationHandler = new AuthenticationHandler(host, configuration);
            IHandler databaseStructureHandler = new DatabaseStructureHandler(host, configuration);
            IHandler objectGenerationHandler = new ObjectGenerationHandler(host, configuration);
            IHandler mainFormHandler = new MainFormHandler(host, configuration);

            authenticationHandler
                .SetNextHandler(databaseStructureHandler)
                .SetNextHandler(objectGenerationHandler)
                .SetNextHandler(mainFormHandler);

            authenticationHandler.HandleRequest();
        }
    }
}
