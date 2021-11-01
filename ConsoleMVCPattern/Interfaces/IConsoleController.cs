using System;
using ConsoleMVCPattern.Classes;

namespace ConsoleMVCPattern.Interfaces{
    public interface IConsoleController{
        event EventHandler<ConsoleControllerEventHandler> ChangeControl;
        void Initialize();

    }
}