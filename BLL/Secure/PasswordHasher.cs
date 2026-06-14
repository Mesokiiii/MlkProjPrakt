using System.Security.Cryptography;
using System.Text;

// Хеширование паролей алгоритмом SHA-256
public static class PasswordHasher
{
    // Принимает текстовый пароль, возвращает хеш-строку
    public static string Hash(string userTextPassword)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(userTextPassword));

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
