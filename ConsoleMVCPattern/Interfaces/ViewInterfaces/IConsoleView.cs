namespace ConsoleMVCPattern.Interfaces.ViewInterfaces{
    public interface IConsoleView{
        object Model {get;}
        void Render();
    }
}