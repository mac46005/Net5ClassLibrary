using System.Collections.Generic;
using DesignPatterns.ClassLib.Interfaces.Builder;

namespace DesignPatterns.ClassLib.Classes.Builder{
    public class Product{
        private List<IComponent> _components = new List<IComponent>();
        public void AddComponents(List<IComponent> comps){
            _components.AddRange(comps);
        }
        public override string ToString()
        {
            return "Product components:" + string.Join("",_components);
        }
    }
}