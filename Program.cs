using System.Configuration;
using System.Data.OleDb;
using Mb.UI.Database;
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
        ApplicationConfiguration.Initialize();

        // Проверка наличия драйвера OleDb — пробуем создать подключение
        try
        {
            string cs = ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString;
            using var testConnection = new OleDbConnection(cs);
            testConnection.Open();
            testConnection.Close();
        }
        catch (Exception)
        {
            MessageBox.Show(
                "Не удалось подключиться к базе данных.\n" +
                "Убедитесь, что драйвер Microsoft Access Database Engine установлен.",
                "Ошибка запуска", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

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

        services.AddTransient<DatabaseForm>();
        services.AddTransient<RegisterForm>();
        services.AddTransient<LoginForm>();
        services.AddTransient<Mb.UI.Profile.ProfileForm>();
        services.AddTransient<Mb.UI.Reports.ReportsForm>();
        services.AddTransient<Mb.UI.About.AboutForm>();
    }
}
