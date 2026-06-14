namespace Mb.Tests;

// Mock-объект (заглушка) для IDbManager.
// Имитирует поведение настоящей БД в памяти, чтобы тестировать AuthService
// в полной изоляции от Microsoft Access (без реальных подключений).
public class FakeDbManager : IDbManager
{
    // "База данных" в памяти: логин -> (хеш_пароля, роль)
    private readonly Dictionary<string, (string Hash, string Role)> users = new();

    // Счётчики вызовов — нужны, чтобы тесты могли проверить,
    // действительно ли AuthService обращался к БД
    public int ValidateUserCalls { get; private set; }
    public int CreateUserCalls { get; private set; }
    public int ChangePasswordCalls { get; private set; }

    // Заранее добавляем пользователя в "БД" (хелпер для тестов)
    public void Seed(string login, string hash, string role)
    {
        users[login] = (hash, role);
    }

    public string ValidateUser(string login, string password)
    {
        ValidateUserCalls++;
        if (users.TryGetValue(login, out var data) && data.Hash == password)
        {
            return data.Role;
        }
        return null;
    }

    public bool CreateUser(string login, string hashedPassword, string role)
    {
        CreateUserCalls++;
        if (users.ContainsKey(login)) return false; // имитация UNIQUE-ограничения
        users[login] = (hashedPassword, role);
        return true;
    }

    public bool ChangePassword(string login, string oldHashedPassword, string newHashedPassword)
    {
        ChangePasswordCalls++;
        if (users.TryGetValue(login, out var data) && data.Hash == oldHashedPassword)
        {
            users[login] = (newHashedPassword, data.Role);
            return true;
        }
        return false;
    }
}
