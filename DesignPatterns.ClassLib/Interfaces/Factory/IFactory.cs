namespace DesignPatterns.ClassLib.Interfaces.Factory{
    public interface IFactory{
        public T CreateObject<T,U>(U parameter);
    }
}