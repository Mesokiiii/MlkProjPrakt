using Mb.UI.Login;
using Microsoft.Extensions.DependencyInjection;

namespace Mb;

public partial class MainMenu : Form
{
    private readonly IServiceProvider services;

    public MainMenu(IServiceProvider services)
    {
        this.services = services;
        InitializeComponent();
    }
    private void pnlDatabase_Click(object sender, EventArgs e)
    {
        // 1. Проверяем: если пользователь УЖЕ вошел в систему
        if (UserSession.IsLoggedIn)
        {
            OpenDataBaseForm();
            return; // Ключевое слово return сразу прерывает метод. Всё, что ниже, выполняться не будет!
        }

        // 2. Если пользователь НЕ вошел — показываем предупреждение
        MessageBox.Show("Для доступа необходимо войти в систему.", 
                        "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        // Достаем форму логина
        LoginForm loginForm = services.GetRequiredService<LoginForm>();

        // Открываем её модально (ShowDialog)
        if (loginForm.ShowDialog() == DialogResult.OK)
        {
            // Если вход успешный — открываем базу
            OpenDataBaseForm();
        }
    }

    private void OpenDataBaseForm()
    {
        MessageBox.Show($"Успех! Вы вошли как: {UserSession.CurrentUserName} (Роль: {UserSession.CurrentRole}).\n\nЗдесь мы очень скоро откроем нашу DataViewForm!", 
                        "Доступ разрешен", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    private void btnExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
