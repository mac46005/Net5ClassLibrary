using System.Collections.Generic;
using ConsoleMVCPattern.Interfaces;

namespace ConsoleMVCPattern.Classes{
    public class Controller : IController{
        private IModel model;
        public List<IView> ViewList { get; set; }
        private IView responseView;
        public Controller(){
            responseView = new View();
        }
        public void RequestView(IView view){
            model = new Model();
            responseView.GetID = model.GenerateId(view.GetID);
        }
        public IView ResponseView(){
            return responseView;
        }
    }
}