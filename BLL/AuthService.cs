using Microsoft.VisualBasic.ApplicationServices;

public class AuthService
{
    
    public static bool Login(string login, string userTextPassword)
    {
        string hashedPassword = PasswordHasher.Hash(userTextPassword);
        string role = DbContext.Instance.ValidateUser(login, hashedPassword);

        if (role != null)
        {
            UserSession.CurrentRole = role;
            UserSession.CurrentUserName = login;
            return true;
        }
        return false;
    }

    public static bool Register(string login, string password, string role)
    {
        string hashedPassword = PasswordHasher.Hash(password);

        return DbContext.Instance.CreateUser(login, hashedPassword, role);

    }
    public static void LogOut()
    {
        UserSession.Logout();
        
    }
}