using System;
using ConsoleMVCPattern.Interfaces;
using ConsoleMVCPattern.Interfaces.ViewInterfaces;

namespace ConsoleMVCPattern.Classes{
    public abstract class ConsoleController : IConsoleController
    {
        public string _viewStart;
        public object Model { get; set; }
        public ConsoleController()
        {
            
        }
        public ConsoleController(string viewStart)
        {
            _viewStart = viewStart;
        }
        public virtual void Initialize(){

        }

        //* START CHANGE CONTROL EVENT
        public event EventHandler<ConsoleControllerEventHandler> ChangeControl;
         protected virtual void OnChangeController(IConsoleController controller){
            if(ChangeControl != null){
                ChangeControl(this,new ConsoleControllerEventHandler{ConsoleController = controller});
            }
        }
        //! END CHANGE CONTROL EVENT


        //*START VIEWCONSOLEVIEWRESULT EVENT
        public EventHandler<ConsoleViewResultArgs> ViewConsoleViewResult;
        public virtual void ConsoleViewResult(IConsoleView cv)
        {
            if(ViewConsoleViewResult != null){
                ViewConsoleViewResult(this,new ConsoleViewResultArgs{ConsoleView = cv});
            }
        }
        //!END VIEWCONSOLEVIEWRESULT EVENT
    }
}