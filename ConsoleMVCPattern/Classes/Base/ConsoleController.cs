using System;
using ConsoleMVCPattern.Interfaces;
using ConsoleMVCPattern.Interfaces.ViewInterfaces;

namespace ConsoleMVCPattern.Classes{
    public abstract class ConsoleController : IConsoleController
    {
        public string _viewStart;
        public object Model { get; set; }
        
    }
}