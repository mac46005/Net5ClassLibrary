using static System.Console;
using ConsoleMVCPattern.Interfaces.ViewInterfaces;
using ConsoleMVCPattern.Classes.EventArgs;
using System;

namespace ConsoleMVCPattern.Classes.Base{
    public class ConsoleView : IConsoleView
    {
        public string ViewName {get => this.GetType().Name; }

        public object Model { get; set; }

        public virtual void Render()
        {
            WriteLine("Hello World!");
        }




        public event EventHandler<ConsoleViewEventArgs> ViewEnded;
        protected virtual void OnConsoleViewEnd(){
            if(ViewEnded != null){
                ViewEnded(this,new ConsoleViewEventArgs(){Model = this.Model});
            }
        }
    }
}