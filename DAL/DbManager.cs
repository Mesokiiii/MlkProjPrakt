using System.Data.OleDb;
using System.IO;

// Класс для работы с пользователями (авторизация, регистрация, смена пароля)
public class DbManager : IDbManager
{
    private readonly string connectionString;

    public DbManager(string connectionString)
    {
        this.connectionString = connectionString;
    }

    // Загружает SQL-запрос из файла в папке DAL/Queries
    private string GetSqlQuery(string fileName)
    {
        string sqlFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DAL", "Queries");
        string fullPath = Path.Combine(sqlFolderPath, fileName);

        if (!File.Exists(fullPath))
        {
            throw new FileNotFoundException($"Файл запроса не найден: {fullPath}");
        }

        return File.ReadAllText(fullPath);
    }

    // Проверка логина и пароля, возвращает роль пользователя или null
    public string ValidateUser(string login, string password)
    {
        string query = GetSqlQuery("ValidateUser.sql");

        using (OleDbConnection oleDbConnection = new OleDbConnection(connectionString))
        {
            using (OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection))
            {
                oleDbCommand.Parameters.AddWithValue("?", login);
                oleDbCommand.Parameters.AddWithValue("?", password);

                try
                {
                    oleDbConnection.Open();
                    object result = oleDbCommand.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка при проверке пользователя: " + ex.Message);
                }
            }
        }
        return null;
    }

    // Создание нового пользователя в БД
    public bool CreateUser(string login, string hashedPassword, string role)
    {
        string query = GetSqlQuery("CreateUser.sql");

        using (OleDbConnection oleDbConnection = new OleDbConnection(connectionString))
        {
            using (OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection))
            {
                oleDbCommand.Parameters.AddWithValue("?", login);
                oleDbCommand.Parameters.AddWithValue("?", hashedPassword);
                oleDbCommand.Parameters.AddWithValue("?", role);

                try
                {
                    oleDbConnection.Open();
                    int rowsAffected = oleDbCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка при создании пользователя", ex);
                }
            }
        }
    }

    // Смена пароля: проверяет старый пароль и заменяет на новый
    public bool ChangePassword(string login, string oldHashedPassword, string newHashedPassword)
    {
        string query = GetSqlQuery("ChangePassword.sql");

        using (OleDbConnection oleDbConnection = new OleDbConnection(connectionString))
        {
            using (OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection))
            {
                oleDbCommand.Parameters.AddWithValue("?", newHashedPassword);
                oleDbCommand.Parameters.AddWithValue("?", login);
                oleDbCommand.Parameters.AddWithValue("?", oldHashedPassword);

                try
                {
                    oleDbConnection.Open();
                    int rowsAffected = oleDbCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка при смене пароля", ex);
                }
            }
        }
    }
}
