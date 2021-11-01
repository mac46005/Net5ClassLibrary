using System;
using ConsoleMVCPattern.Classes;

namespace ConsoleMVCPattern.Interfaces{
    public interface IConsoleController : IHaveModel{
        event EventHandler<ConsoleControllerEventHandler> ChangeControl;
        void Initialize();
        void ViewResult();
    }
}