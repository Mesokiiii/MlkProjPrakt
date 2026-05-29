using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
    public class DataRepository
    {
        private readonly string connectionString;

        public DataRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // чтение
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

        // ==
        public bool DeleteRecord(string tableName, int recordId)
        {
            string query = $"DELETE FROM [{tableName}] WHERE [ID] = ?";
            
            var parameters = new Dictionary<string, object>
            {
                { "id", recordId }
            };

            return ExecuteNonQuery(query, parameters);
        }
        

        // =====
        private bool ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
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