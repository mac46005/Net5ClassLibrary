using System;
using ConsoleMVCPattern.Interfaces;

namespace ConsoleMVCPattern.Classes{
    public abstract class ConsoleController : IConsoleController
    {
        public event EventHandler<ConsoleControllerEventHandler> ChangeControl;

        public void Initialize()
        {
            throw new System.NotImplementedException();
        }

        protected virtual void OnChangeController(IConsoleController controller){
            if(ChangeControl != null){
                ChangeControl(this,new ConsoleControllerEventHandler{ConsoleController = controller});
            }
        }
    }
}