using System.Configuration;
using System.Data.OleDb;
using System.Linq.Expressions; 
using System.IO;

public class DbManager
{
    private readonly string connectionString;

    public DbManager(string connectionString)
    {
        this.connectionString = connectionString;
    }
    
    // public bool TestConnection()
    // {
    //     using (OleDbConnection oleDbConnection = new OleDbConnection(connectionString))
    //     {
    //         try
    //         {
    //             oleDbConnection.Open();
    //             return true;
    //         } catch (Exception)
    //         {
    //             return false;
    //         }
    //     } 
    // }
    private string GetSqlQuery(string fileName)
    {
        string sqlFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DAL", "Queries");
        string fullPath = Path.Combine(sqlFolderPath, fileName);

        if (!File.Exists(fullPath))
        {
            throw new FileNotFoundException($"Файл запроса не найден. Проверьте наличие файла {fullPath}");
        }

        return File.ReadAllText(fullPath);
    }

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

                } catch (Exception ex)
                {
                    throw new Exception("Ошибка при получении пользователя" + ex.Message);

                }
            }
        } return null;
    }

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
                
                   // Если добавлена хотя бы 1 строка, значит регистрация успешна
                   return rowsAffected > 0; 
                }
                catch (Exception ex)
                                       {
                // Сохраняем оригинальный StackTrace через inner exception
                throw new Exception("Ошибка при создании нового пользователя", ex);
                                       }
            }
        }
    }
}