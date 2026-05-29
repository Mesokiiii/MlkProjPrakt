public static class UserSession
{
    public static string CurrentUserName { get; set; }
    public static string CurrentRole { get; set; }

    public static bool IsLoggedIn => !string.IsNullOrEmpty(CurrentUserName);

    public static void Logout()
    {
        CurrentUserName = null;
        CurrentRole = null;

    }
}