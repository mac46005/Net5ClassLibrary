namespace DesignPatterns.ClassLib.Interfaces.Factory{
    public interface IFactory{
        public T Manufacture<T,U>(U parameter);
    }
}