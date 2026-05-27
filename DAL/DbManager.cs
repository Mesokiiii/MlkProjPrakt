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
    
    public bool TestConnection()
    {
        using (OleDbConnection oleDbConnection = new OleDbConnection(connectionString))
        {
            try
            {
                oleDbConnection.Open();
                return true;
            } catch (Exception)
            {
                return false;
            }
        } 
    }

    private string GetSqlQuery(string fileName)
    {
        string sqlFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DAL", "Queries");
        string fullPath = Path.Combine(sqlFolderPath, fileName);

        if (!File.Exists(fullPath))
        {
            throw new FileNotFoundException($"Скюл файл не найден. {fullPath}");
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
}