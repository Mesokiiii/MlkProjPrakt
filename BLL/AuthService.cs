using System;

// Сервис авторизации: вход, регистрация, выход, смена пароля
public class AuthService
{
    private readonly IDbManager db;
    private int failedAttempts = 0;
    private DateTime? lockoutEndTime = null;

    public AuthService(IDbManager db)
    {
        this.db = db;
    }

    // Вход в систему с защитой от брутфорса (3 попытки → блокировка 30 мин)
    public bool Login(string login, string userTextPassword)
    {
        // Проверяем, не заблокирован ли пользователь
        if (lockoutEndTime.HasValue)
        {
            if (DateTime.Now < lockoutEndTime.Value)
            {
                // Считаем, сколько минут осталось до конца блокировки
                TimeSpan timeLeft = lockoutEndTime.Value - DateTime.Now; // разница между временем окончания и текущим временем
                int minutesLeft = timeLeft.Minutes + 1; // берём минуты из разницы и +1 для округления вверх
                throw new Exception("Система заблокирована. Попробуйте через " + minutesLeft + " минут.");
            }
            else
            {
                // Время блокировки истекло
                failedAttempts = 0;
                lockoutEndTime = null;
            }
        }

        // Хешируем пароль и проверяем в БД
        string hashedPassword = PasswordHasher.Hash(userTextPassword);
        string role = db.ValidateUser(login, hashedPassword);

        if (role != null)
        {
            // Успешный вход — сохраняем сессию
            failedAttempts = 0;
            UserSession.CurrentRole = role;
            UserSession.CurrentUserName = login;
            return true;
        }
        else
        {
            // Неудачная попытка
            failedAttempts++;

            if (failedAttempts >= 3)
            {
                lockoutEndTime = DateTime.Now.AddMinutes(30);
                throw new Exception("Слишком много попыток. Повторите через 30 минут.");
            }
            return false;
        }
    }

    // Регистрация нового пользователя с ролью "Гость"
    public bool Register(string login, string password, string role)
    {
        string hashedPassword = PasswordHasher.Hash(password);
        return db.CreateUser(login, hashedPassword, role);
    }

    // Выход из системы
    public void LogOut()
    {
        UserSession.Logout();
    }

    // Смена пароля текущего пользователя
    public bool ChangePassword(string oldPassword, string newPassword)
    {
        string login = UserSession.CurrentUserName;
        string oldHash = PasswordHasher.Hash(oldPassword);
        string newHash = PasswordHasher.Hash(newPassword);

        return db.ChangePassword(login, oldHash, newHash);
    }
}
