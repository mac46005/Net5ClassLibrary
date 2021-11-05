using static System.Console;
using ConsoleMVCPattern.Interfaces.ViewInterfaces;

namespace ConsoleMVCPattern.Classes.Base{
    public class ConsoleView : IConsoleView
    {
        public string ViewName {get => this.GetType().Name; }

        public object Model { get; set; }

        public virtual void Render()
        {
            WriteLine("Hello World!");
        }


    }
}