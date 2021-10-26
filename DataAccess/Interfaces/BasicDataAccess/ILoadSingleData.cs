using System;

namespace DataAccess.Interfaces.BasicDataAccess{
    public interface ILoadSingleData : IDisposable
    {
        T LoadSingleData<T,U>(string storedProcedure,string connectionStringName,U parameters);
    }
}