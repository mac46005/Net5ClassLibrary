using DesignPatterns.ClassLib.Classes.Builder;

namespace DesignPatterns.ClassLib.Interfaces.Builder{
    public interface IBuilder{
        void BuildParts();
        Product GetProduct();
    }
}