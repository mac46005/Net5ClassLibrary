namespace ConsoleMVCPattern.Interfaces{
    public interface IView
    {
        IModel model {get;set;}
        void Display();
    }
}