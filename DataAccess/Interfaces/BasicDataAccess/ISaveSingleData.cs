namespace DataAccess.Interfaces.BasicDataAccess
{
    public interface ISaveSingleData
    {
        void SaveSingleData<T>(string storedProcedure,string connectionStringName,T obj);
    }
}