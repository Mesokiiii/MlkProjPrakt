using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;

public class DataRepository
{
    private readonly string connectionString;

    // Конструктор принимает строку подключения к БД
    public DataRepository(string connectionString)
    {
        this.connectionString = connectionString;
    }

    // Получение всех записей из указанной таблицы
    public DataTable GetDataTable(string tableName)
    {
        DataTable dataTable = new DataTable();
        string query = $"SELECT * FROM [{tableName}]";

        using (OleDbConnection oleDbConnection = new OleDbConnection(connectionString))
        {
            using (OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(oleDbCommand))
                {
                    try
                    {
                        adapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Не удалось загрузить таблицу {tableName}: {ex.Message}", ex);
                    }
                }
            }
        }
        return dataTable;
    }

    // Удаление записи по первичному ключу
    public bool DeleteRecord(string tableName, string primaryKeyName, int recordId)
    {
        string query = $"DELETE FROM [{tableName}] WHERE [{primaryKeyName}] = ?";

        var parameters = new Dictionary<string, object>
        {
            { "id", recordId }
        };

        return ExecuteNonQuery(query, parameters);
    }

    // Вставка новой записи в таблицу
    public bool InsertRecord(string tableName, Dictionary<string, object> data)
    {
        string columns = "";
        string values = "";
        int count = 0;

        // Формируем списки столбцов и плейсхолдеров
        foreach (var pair in data)
        {
            columns += "[" + pair.Key + "]";
            values += "?";

            if (count < data.Count - 1)
            {
                columns += ", ";
                values += ", ";
            }

            count++;
        }

        string query = "INSERT INTO [" + tableName + "] (" + columns + ") VALUES (" + values + ")";

        return ExecuteNonQuery(query, data);
    }

    // Обновление существующей записи по первичному ключу
    public bool UpdateRecord(string tableName, string pkName, int pkValue, Dictionary<string, object> data)
    {
        string setClause = "";
        int count = 0;

        // Формируем SET часть запроса
        foreach (var key in data.Keys)
        {
            setClause += "[" + key + "] = ?";

            if (count < data.Count - 1)
            {
                setClause += ", ";
            }
            count++;
        }

        string query = "UPDATE [" + tableName + "] SET " + setClause + " WHERE [" + pkName + "] = ?";

        // Порядок параметров важен: сначала SET значения, потом WHERE
        Dictionary<string, object> parameters = new Dictionary<string, object>();

        foreach (var pair in data)
        {
            parameters.Add(pair.Key, pair.Value);
        }

        // ID в конец — для WHERE условия
        parameters.Add(pkName, pkValue);

        return ExecuteNonQuery(query, parameters);
    }

    // Базовый метод выполнения INSERT/UPDATE/DELETE запросов
    private bool ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
    {
        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                // Добавляем параметры в порядке их следования в запросе
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue("?", param.Value ?? DBNull.Value);
                    }
                }

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ошибка при записи в БД: {ex.Message}", ex);
                }
            }
        }
    }
}
