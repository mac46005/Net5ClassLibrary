using ConsoleMVCPattern.Interfaces.ViewInterfaces;

namespace ConsoleMVCPattern.Classes{
    public class ConsoleView : IConsoleView
    {
        public string ViewName => throw new System.NotImplementedException();

        public object Model { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Render()
        {
            throw new System.NotImplementedException();
        }
    }
}