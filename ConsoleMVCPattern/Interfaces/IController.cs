namespace ConsoleMVCPattern.Interfaces{
    public interface IController{
        void RequestView(IView view);
        IView ResponseView();
    }
}