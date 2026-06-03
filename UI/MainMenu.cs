using Mb.UI.Login;
using Microsoft.Extensions.DependencyInjection;
using Mb.UI.Database;

namespace Mb;

// Главное меню приложения — точка навигации между формами
public partial class MainMenu : Form
{
    private readonly IServiceProvider services;

    public MainMenu(IServiceProvider services)
    {
        this.services = services;
        InitializeComponent();
    }

    // Открытие базы данных (с проверкой авторизации)
    private void pnlDatabase_Click(object sender, EventArgs e)
    {
        if (UserSession.IsLoggedIn)
        {
            OpenDataBaseForm();
            return;
        }

        MessageBox.Show("Для доступа необходимо войти в систему.",
                        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        LoginForm loginForm = services.GetRequiredService<LoginForm>();
        if (loginForm.ShowDialog() == DialogResult.OK)
        {
            OpenDataBaseForm();
        }
    }

    private void OpenDataBaseForm()
    {
        DatabaseForm databaseForm = services.GetRequiredService<DatabaseForm>();
        this.Hide();
        databaseForm.ShowDialog();
        this.Show();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    // Личный кабинет (с проверкой авторизации)
    private void pnlProfile_Click(object sender, EventArgs e)
    {
        if (UserSession.IsLoggedIn)
        {
            var profileForm = services.GetRequiredService<Mb.UI.Profile.ProfileForm>();
            profileForm.ShowDialog();
            return;
        }

        MessageBox.Show("Для доступа необходимо войти в систему.",
                        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        var loginForm = services.GetRequiredService<Mb.UI.Login.LoginForm>();
        if (loginForm.ShowDialog() == DialogResult.OK)
        {
            var profileForm = services.GetRequiredService<Mb.UI.Profile.ProfileForm>();
            profileForm.ShowDialog();
        }
    }

    // Отчёты (с проверкой авторизации)
    private void pnlReports_Click(object sender, EventArgs e)
    {
        if (UserSession.IsLoggedIn)
        {
            var reportsForm = services.GetRequiredService<Mb.UI.Reports.ReportsForm>();
            reportsForm.ShowDialog();
            return;
        }

        MessageBox.Show("Для доступа необходимо войти в систему.",
                        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        var loginForm = services.GetRequiredService<Mb.UI.Login.LoginForm>();
        if (loginForm.ShowDialog() == DialogResult.OK)
        {
            var reportsForm = services.GetRequiredService<Mb.UI.Reports.ReportsForm>();
            reportsForm.ShowDialog();
        }
    }

    // О программе (доступно без авторизации)
    private void pnlAbout_Click(object sender, EventArgs e)
    {
        var aboutForm = services.GetRequiredService<Mb.UI.About.AboutForm>();
        aboutForm.ShowDialog();
    }
}
