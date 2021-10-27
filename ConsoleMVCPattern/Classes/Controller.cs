using ConsoleMVCPattern.Interfaces;
using System.Collections.Generic;

namespace ConsoleMVCPattern.Classes{
    public class Controller : IController{
        private IModel model;
        private IView responseView;
        public List<IView> ViewList {get;set;}
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