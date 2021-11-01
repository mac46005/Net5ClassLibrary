namespace ConsoleMVCPattern.Interfaces{
    public interface IConsoleController{
        delegate void ControllerEventHandler(IConsoleController controller);
        event ControllerEventHandler ChangeControl;
        void Initialize();

    }
}