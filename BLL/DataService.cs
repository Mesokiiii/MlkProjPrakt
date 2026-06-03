using System.Data;

// Бизнес-логика для работы с данными таблиц
public class DataService
{
    private readonly DataRepository repository;

    public DataService(DataRepository repository)
    {
        this.repository = repository;
    }

    // Получение данных таблицы по имени
    public DataTable GetTable(string tableName)
    {
        try
        {
            return repository.GetDataTable(tableName);
        }
        catch (Exception ex)
        {
            throw new Exception($"Ошибка при получении данных таблицы: {ex.Message}", ex);
        }
    }

    // Определяет имя первичного ключа для каждой таблицы
    private string GetPrimaryKeyName(string tableName)
    {
        switch (tableName)
        {
            case "Врачи":
                return "Код_врача";
            case "Больницы":
                return "Номер_больницы";
            case "Отделения":
                return "Код_отделения";
            case "Пользователи":
                return "Код_пользователя";
            default:
                throw new Exception("Неизвестная таблица: " + tableName);
        }
    }

    // Удаление записи (только для Администратора)
    public bool DataRecord(string tableName, int id)
    {
        if (UserSession.CurrentRole == "Гость")
        {
            throw new Exception("У вас нет прав для удаления записей.");
        }

        try
        {
            string pkName = GetPrimaryKeyName(tableName);
            return repository.DeleteRecord(tableName, pkName, id);
        }
        catch (Exception ex)
        {
            throw new Exception($"Ошибка при удалении: {ex.Message}");
        }
    }

    // Сохранение записи: если передан id — обновление, иначе — вставка
    public bool SaveRecord(string tableName, Dictionary<string, string> values, int? id = null)
    {
        if (UserSession.CurrentRole == "Гость")
        {
            throw new Exception("У вас нет прав для изменения данных.");
        }

        var data = values.ToDictionary(k => k.Key, v => (object)v.Value);
        string pkName = GetPrimaryKeyName(tableName);

        if (id.HasValue)
        {
            // Обновление — убираем PK из данных, чтобы не перезаписать его
            if (data.ContainsKey(pkName)) data.Remove(pkName);
            return repository.UpdateRecord(tableName, pkName, id.Value, data);
        }
        else
        {
            // Вставка — PK генерируется автоматически
            if (data.ContainsKey(pkName)) data.Remove(pkName);
            return repository.InsertRecord(tableName, data);
        }
    }
}
