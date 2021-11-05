using System;
using ConsoleMVCPattern.Classes.EventArgs;
using ConsoleMVCPattern.Interfaces;
using ConsoleMVCPattern.Interfaces.ViewInterfaces;

namespace ConsoleMVCPattern.Classes.Base{
    public abstract class ConsoleController : IConsoleController
    {
        public string _viewStart;
        public object Model { get; set; }
        


        public event EventHandler<ConsoleControllerEventArgs> ControllerChange;
        protected virtual void OnActionToChangeController(IConsoleController controller){
            if(ControllerChange != null){
                ControllerChange(this,new ConsoleControllerEventArgs(){ConsoleController = controller});
            }
        }
    }
}