using System;
using ConsoleMVCPattern.Classes;

namespace ConsoleMVCPattern.Interfaces{
    public interface IConsoleController : IHaveModel{
        public object Model {get;set;}
        event EventHandler<ConsoleControllerEventHandler> ChangeControl;
        void Initialize();

    }
}