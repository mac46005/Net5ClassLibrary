namespace DesignPatterns.ClassLib.Interfaces.Factory{
    public interface IFactory<T,U>{
        T CreateObject(U parameters);
    }
}