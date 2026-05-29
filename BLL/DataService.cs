using System.Data;

public class DataService
{
    private readonly DataRepository repository;

    public DataService(DataRepository repository)
    {
        this.repository = repository;
    }

    public DataTable GetTable(string tableName)
    {
        try
        {
            return repository.GetDataTable(tableName);
        } catch (Exception ex)
        {
            throw new Exception($"Ошибка при получении данных таблицч: {ex.Message}", ex);
        }
    }

    public bool DataRecord(string tableName, int id)
    {
        
        if (UserSession.CurrentRole == "Гость")
        {
            throw new Exception("У вас нет прав для удаления записей. Обратитесь к администратору.");
        }

        try
        {
            return repository.DeleteRecord(tableName, id);
        } 
        catch (Exception ex)
        {
            throw new Exception($"Ошибка бизнес-логики при удалении записи: {ex.Message}");
        }
    }
}