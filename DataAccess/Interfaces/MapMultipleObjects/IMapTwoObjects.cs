using System;
using System.Collections.Generic;

namespace DataAccess.Interfaces.MapMultipleObjects{
    public interface IMapTwoObjects: IDisposable{
        List<T> MapTwoObjects<T,U,V,W>(string storedProcedure,string connectionStringName,Func<U,V,T> map, W parameters);
    }
}