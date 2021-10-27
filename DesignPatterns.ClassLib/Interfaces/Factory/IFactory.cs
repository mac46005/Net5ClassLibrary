namespace DesignPatterns.ClassLib.Interfaces.Factory{
    public interface IFactory{
        T CreateObject<T,U>(U parameters);
    }
}