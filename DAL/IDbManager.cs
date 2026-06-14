// Интерфейс для работы с пользователями в БД.
// Нужен, чтобы сервис AuthService можно было тестировать без реальной базы данных
public interface IDbManager
{
    // Проверка логина и пароля. Возвращает роль пользователя или null.
    string ValidateUser(string login, string password);

    // Создание нового пользователя.
    bool CreateUser(string login, string hashedPassword, string role);

    // Смена пароля.
    bool ChangePassword(string login, string oldHashedPassword, string newHashedPassword);
}
