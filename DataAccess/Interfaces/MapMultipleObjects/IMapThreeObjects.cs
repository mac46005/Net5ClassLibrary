using System;
using System.Collections.Generic;

namespace DataAccess.Interfaces.MapMultipleObjects{
    public interface IMapThreeObjects : IDisposable{
        List<T> MapThreeObjects<T,U,V,W,X>(string storedProcedure,string connectionStringName,Func<U,V,W,T> map,X parameters);
    }
}