using System.Security.Cryptography;
using System.Text;

public static class PasswordHasher
{
    public static string Hash(string userTextPassword)
    {
        using (SHA256 sha265 = SHA256.Create())
        {
            byte[] bytes = sha265.ComputeHash(Encoding.UTF8.GetBytes(userTextPassword));

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                stringBuilder.Append(bytes[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }
}