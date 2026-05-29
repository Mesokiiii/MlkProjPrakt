using System.Configuration;
using Mb.UI.Login;
using Mb.UI.Register;
using Microsoft.Extensions.DependencyInjection;

namespace Mb;

static class Program
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

        using var provider = services.BuildServiceProvider();
        Application.Run(provider.GetRequiredService<MainMenu>());
    }

    static void ConfigureServices(ServiceCollection services)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString;

        services.AddSingleton(new DbManager(connectionString));
        services.AddSingleton(new DataRepository(connectionString));
        
        services.AddSingleton<DataService>();
        services.AddSingleton<AuthService>();
        services.AddSingleton<MainMenu>();

        services.AddTransient<RegisterForm>();
        services.AddTransient<LoginForm>();
    }
}
