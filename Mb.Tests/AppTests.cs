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
}
