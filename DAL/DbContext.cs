using System.Configuration;

public static class DbContext
{
    private static DbManager dbInstance;

    public static DbManager Instance
    {
        get
        {
            if(dbInstance == null)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString;
                dbInstance = new DbManager(connectionString);
            }

            return dbInstance;
        } 
    }
    
}