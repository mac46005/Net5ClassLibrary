using System.Collections.Generic;
using DesignPatterns.ClassLib.Interfaces.Builder;

namespace DesignPatterns.ClassLib.Classes.Builder{
    public class ConcreteBuilder1 : IBuilder{
        private Product _product = new Product();
        public void BuildParts(){
            _product.AddComponents(new List<IComponent> { new ConcreteComponent1("Comp1")});
        }
        public Product GetProduct(){
            return _product;
        }
    }
}