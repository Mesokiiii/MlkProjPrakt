using System;

public class AuthService
{
    private readonly DbManager db;
    private int failedAttempts = 0;
    private DateTime? lockoutEndTime = null;

    public AuthService(DbManager db)
    {
        this.db = db;
    }

    public bool Login(string login, string userTextPassword)
    {
        if (lockoutEndTime.HasValue)
        {
            if (DateTime.Now < lockoutEndTime.Value)
            {
                int remainingMinutes = (int)(lockoutEndTime.Value - DateTime.Now).TotalMinutes;

                if (remainingMinutes <= 0)
                {
                    remainingMinutes = 1;
                }

                throw new Exception($"Превышено количество попыток входа. Система заблокирована. Попробуйте через {remainingMinutes} минут.");
            }
            else
            {
                // Время блокировки истекло, сбрасываем счетчики
                failedAttempts = 0;
                lockoutEndTime = null;
            }
        }

        string hashedPassword = PasswordHasher.Hash(userTextPassword);
        string role = db.ValidateUser(login, hashedPassword);

        if (role != null)
        {
            failedAttempts = 0;

            UserSession.CurrentRole = role;
            UserSession.CurrentUserName = login;
            return true;
        }
        else
        {
            failedAttempts++;

            if (failedAttempts >= 3)
            {
                lockoutEndTime = DateTime.Now.AddMinutes(30);
                throw new Exception("Слишком много попыток. повторите через 30 минут");
            }
            return false;
        }
    }

    public bool Register(string login, string password, string role)
    {
        string hashedPassword = PasswordHasher.Hash(password);

        return db.CreateUser(login, hashedPassword, role);
    }

    public void LogOut()
    {
        UserSession.Logout();
    }
}
