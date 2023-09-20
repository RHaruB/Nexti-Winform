using Microsoft.Extensions.DependencyInjection;
using Nexti_Winform.Services;

namespace Nexti_Winform
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            ConfigureServices(services);
            using (var serviceProvider = services.BuildServiceProvider())
            {
                var home = serviceProvider.GetRequiredService<Home>();
                Application.Run(new Home());
            }
           
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<ICliente, ClienteService>()
                .AddScoped<Home>();
        }
    }
}