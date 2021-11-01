namespace ConsoleMVCPattern.Interfaces.ViewInterfaces{
    public interface IConsoleView : IHaveModel{
        string ViewName {get;}
        void Render();
    }
}