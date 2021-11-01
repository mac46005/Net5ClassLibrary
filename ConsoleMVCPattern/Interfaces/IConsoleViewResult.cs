namespace ConsoleMVCPattern.Interfaces.ViewInterfaces{
    public interface IConsoleViewResult{
        object Model {get;}
        IConsoleView View {get;set;}
        
    }
}