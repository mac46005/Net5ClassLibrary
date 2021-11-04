using static System.Console;
using ConsoleMVCPattern.Interfaces.ViewInterfaces;

namespace ConsoleMVCPattern.Classes{
    public class ConsoleView : IConsoleView
    {
        public string ViewName => throw new System.NotImplementedException();

        public object Model { get; set; }

        public virtual void Render()
        {
            WriteLine("Hello World!");
        }
    }
}