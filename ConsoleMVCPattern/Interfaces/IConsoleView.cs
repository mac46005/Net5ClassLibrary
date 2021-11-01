namespace ConsoleMVCPattern.Interfaces.ViewInterfaces{
    public interface IConsoleView{
        string ViewName {get;}
        object Model {get;}
        void Render();
    }
}