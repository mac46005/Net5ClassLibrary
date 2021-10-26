namespace DataAccess.Interfaces.Transactions{
    public interface IRunTransaction : IDisposable{
        void RunTransaction<T,U,V,X>(T obj1,U obj2,string connectionStringName,string storedProcedure1,string storedProcedure2);
    }
}