// Хранит данные текущего авторизованного пользователя
public static class UserSession
{
    public static string CurrentUserName { get; set; }
    public static string CurrentRole { get; set; }

    // true если пользователь вошёл в систему
    public static bool IsLoggedIn => !string.IsNullOrEmpty(CurrentUserName);

    // Сброс сессии при выходе
    public static void Logout()
    {
        CurrentUserName = null;
        CurrentRole = null;
    }
}
