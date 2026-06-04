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

    // Проверка: может ли текущая роль редактировать данную таблицу
    private bool CanEdit(string tableName)
    {
        string role = UserSession.CurrentRole;

        if (role == Roles.Admin) return true;
        if (role == Roles.HeadDoctor && (tableName == "Врачи" || tableName == "Отделения")) return true;

        return false;
    }

    // Удаление записи (только Администратор)
    public bool DataRecord(string tableName, int id)
    {
        if (UserSession.CurrentRole != Roles.Admin)
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

    // Сохранение записи: проверяем права на основе роли
    public bool SaveRecord(string tableName, Dictionary<string, string> values, int? id = null)
    {
        if (!CanEdit(tableName))
        {
            throw new Exception("У вас нет прав для изменения данных этой таблицы.");
        }

        var data = values.ToDictionary(k => k.Key, v => (object)v.Value);
        string pkName = GetPrimaryKeyName(tableName);

        if (id.HasValue)
        {
            if (data.ContainsKey(pkName)) data.Remove(pkName);
            return repository.UpdateRecord(tableName, pkName, id.Value, data);
        }
        else
        {
            if (data.ContainsKey(pkName)) data.Remove(pkName);
            return repository.InsertRecord(tableName, data);
        }
    }
}
