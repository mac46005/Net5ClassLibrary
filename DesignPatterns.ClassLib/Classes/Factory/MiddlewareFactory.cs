using DesignPatterns.ClassLib.Interfaces.Factory;
/// <summary>
/// The factory class that will be used to instantiate the concrete classes depending on the condition
/// </summary>
namespace DesignPatterns.ClassLib.Factory{
    public class MiddlewareFactory{
        public IMiddleware GetMiddleware(int which){
            switch(which){
                case 1: return new Middleware1();
                case 2: return new Middleware2();
                default: return new Middleware1();
            }
        }
    }
}