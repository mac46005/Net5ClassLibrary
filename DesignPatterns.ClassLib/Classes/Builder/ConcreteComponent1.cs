
using DesignPatterns.ClassLib.Interfaces.Builder;

namespace DesignPatterns.ClassLib.Classes.Builder{
    public class ConcreteComponent1 : IComponent{
        private string _name;
        public ConcreteComponent1(string name){
            _name = name;
        }
        public override string ToString()
        {
            return this.GetType().Name + $"[{_name}]";
        }
    }
}