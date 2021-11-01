using ConsoleMVCPattern.Interfaces;

namespace ConsoleMVCPattern.Classes{
    public abstract class ConsoleController : IConsoleController
    {
        public event IConsoleController.ControllerEventHandler ChangeControl;

        public void Initialize()
        {
            throw new System.NotImplementedException();
        }
    }
}