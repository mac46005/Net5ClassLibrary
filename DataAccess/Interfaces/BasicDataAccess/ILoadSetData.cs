using System;
using System.Collections.Generic;

namespace DataAccess.Interfaces.BasicDataAccess{
    public interface ILoadSetData : IDisposable
    {
        List<T> LoadSetData<T,U>(string storedProcedure,string connectionStringName,U parameters);
    }
}