using System.Collections.Generic;
using System.Linq;

namespace ConsoleMVCPattern.Classes{
    public class ConsoleMVCConfig{
        public List<object> ListOfObjects {get;set;}
        public ConsoleMVCConfig()
        {
            GetViewController();
        }

        private void GetViewController(){
            GetType().Assembly.GetTypes()
            .Where(t => t.IsClass)
            .Where(cv => cv.Name.EndsWith("ControllerView"))
            .Where(cc => cc.Name.EndsWith("ConsoleController"))
            .ToList()
            .ForEach(t => ListOfObjects.Add(t));
        }
    }
}