using System;
using ConsoleMVCPattern.Interfaces;

namespace ConsoleMVCPattern.Classes{
    public abstract class ConsoleController : IConsoleController
    {
        public object Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler<ConsoleControllerEventHandler> ChangeControl;
        
        public void Initialize()
        {
            throw new System.NotImplementedException();
        }

        public void ConsoleViewResult()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnChangeController(IConsoleController controller){
            if(ChangeControl != null){
                ChangeControl(this,new ConsoleControllerEventHandler{ConsoleController = controller});
            }
        }
    }
}