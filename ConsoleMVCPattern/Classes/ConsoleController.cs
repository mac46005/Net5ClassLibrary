using System;
using ConsoleMVCPattern.Interfaces;
using ConsoleMVCPattern.Interfaces.ViewInterfaces;

namespace ConsoleMVCPattern.Classes{
    public abstract class ConsoleController : IConsoleController
    {
        public object Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Initialize()
        {
            throw new System.NotImplementedException();
        }

        //* START CHANGE CONTROL EVENT
        public event EventHandler<ConsoleControllerEventHandler> ChangeControl;
         protected virtual void OnChangeController(IConsoleController controller){
            if(ChangeControl != null){
                ChangeControl(this,new ConsoleControllerEventHandler{ConsoleController = controller});
            }
        }
        //! END CHANGE CONTROL EVENT


        public void ConsoleViewResult()
        {
            throw new NotImplementedException();
        }

        public void ViewResult(IConsoleView cv)
        {
            
        }

        public void ViewResult()
        {
            throw new NotImplementedException();
        }
    }
}