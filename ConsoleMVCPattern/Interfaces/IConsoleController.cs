using System;
using ConsoleMVCPattern.Classes;
using ConsoleMVCPattern.Interfaces.ViewInterfaces;

namespace ConsoleMVCPattern.Interfaces{
    public interface IConsoleController : IHaveModel{
        event EventHandler<ConsoleControllerEventHandler> ChangeControl;
        void ConsoleViewResult(IConsoleView cv);
        void Initialize();
        string ControllerName();
    }
}