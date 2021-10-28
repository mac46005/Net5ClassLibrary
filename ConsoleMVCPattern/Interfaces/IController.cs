using System.Collections.Generic;

namespace ConsoleMVCPattern.Interfaces{
    public interface IController{
        void RequestView(IView view);
        IView ResponseView();
        IView View {get;set;}
    }
}