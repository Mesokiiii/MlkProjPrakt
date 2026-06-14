namespace Mb.Tests;

// Модульные тесты для проверки ключевых компонентов системы
public class AppTests
{
    // Тест 1: Хеширование пароля возвращает непустую строку
    [Fact]
    public void PasswordHasher_ReturnsHash()
    {
        string hash = PasswordHasher.Hash("test123");

        Assert.False(string.IsNullOrEmpty(hash));
    }

    // Тест 2: Одинаковые пароли дают одинаковый хеш
    [Fact]
    public void PasswordHasher_SameInput_SameOutput()
    {
        string hash1 = PasswordHasher.Hash("myPassword");
        string hash2 = PasswordHasher.Hash("myPassword");

        Assert.Equal(hash1, hash2);
    }

    // Тест 3: Разные пароли дают разные хеши
    [Fact]
    public void PasswordHasher_DifferentInput_DifferentOutput()
    {
        string hash1 = PasswordHasher.Hash("password1");
        string hash2 = PasswordHasher.Hash("password2");

        Assert.NotEqual(hash1, hash2);
    }

    // Тест 4: UserSession по умолчанию — не авторизован
    [Fact]
    public void UserSession_ByDefault_NotLoggedIn()
    {
        UserSession.Logout(); // сброс

        Assert.False(UserSession.IsLoggedIn);
    }

    // Тест 5: После установки имени — пользователь авторизован
    [Fact]
    public void UserSession_AfterLogin_IsLoggedIn()
    {
        UserSession.CurrentUserName = "admin";
        UserSession.CurrentRole = "Администратор";

        Assert.True(UserSession.IsLoggedIn);
        Assert.Equal("admin", UserSession.CurrentUserName);
        Assert.Equal("Администратор", UserSession.CurrentRole);

        UserSession.Logout(); // чистим за собой
    }

    // Тест 6: После Logout — сессия сброшена
    [Fact]
    public void UserSession_AfterLogout_IsCleared()
    {
        UserSession.CurrentUserName = "user1";
        UserSession.CurrentRole = "Гость";

        UserSession.Logout();

        Assert.False(UserSession.IsLoggedIn);
        Assert.Null(UserSession.CurrentUserName);
        Assert.Null(UserSession.CurrentRole);
    }

    // ==================== Тесты AuthService с моком БД ====================
    // Используем FakeDbManager — заглушку, которая работает в памяти,
    // без реального подключения к Microsoft Access.

    // Тест 7: Вход с правильным логином и паролем — успех + установлена роль
    [Fact]
    public void AuthService_Login_CorrectPassword_ReturnsTrue()
    {
        var fakeDb = new FakeDbManager();
        fakeDb.Seed("admin", PasswordHasher.Hash("1234"), Roles.Admin);
        var auth = new AuthService(fakeDb);

        bool result = auth.Login("admin", "1234");

        Assert.True(result);
        Assert.Equal(Roles.Admin, UserSession.CurrentRole);
        Assert.Equal(1, fakeDb.ValidateUserCalls); // проверили, что AuthService обратился к БД
        UserSession.Logout();
    }

    // Тест 8: Вход с неправильным паролем — false
    [Fact]
    public void AuthService_Login_WrongPassword_ReturnsFalse()
    {
        var fakeDb = new FakeDbManager();
        fakeDb.Seed("user", PasswordHasher.Hash("realPass"), Roles.Guest);
        var auth = new AuthService(fakeDb);

        bool result = auth.Login("user", "wrongPass");

        Assert.False(result);
    }

    // Тест 9: После 3 неудачных попыток подряд — выбрасывается исключение (блокировка)
    [Fact]
    public void AuthService_Login_ThreeWrongAttempts_ThrowsLockout()
    {
        var fakeDb = new FakeDbManager();
        fakeDb.Seed("user", PasswordHasher.Hash("realPass"), Roles.Guest);
        var auth = new AuthService(fakeDb);

        auth.Login("user", "wrong1"); // 1
        auth.Login("user", "wrong2"); // 2

        // Третья попытка должна выбросить Exception
        Assert.Throws<Exception>(() => auth.Login("user", "wrong3"));
    }

    // Тест 10: Регистрация нового пользователя — true и пользователь появился в БД
    [Fact]
    public void AuthService_Register_NewUser_ReturnsTrue()
    {
        var fakeDb = new FakeDbManager();
        var auth = new AuthService(fakeDb);

        bool result = auth.Register("newUser", "password123", Roles.Guest);

        Assert.True(result);
        Assert.Equal(1, fakeDb.CreateUserCalls);
    }

    // Тест 11: Регистрация с существующим логином — false (имитация UNIQUE-ограничения)
    [Fact]
    public void AuthService_Register_ExistingLogin_ReturnsFalse()
    {
        var fakeDb = new FakeDbManager();
        fakeDb.Seed("admin", PasswordHasher.Hash("1234"), Roles.Admin);
        var auth = new AuthService(fakeDb);

        bool result = auth.Register("admin", "newpass", Roles.Guest);

        Assert.False(result);
    }
}
