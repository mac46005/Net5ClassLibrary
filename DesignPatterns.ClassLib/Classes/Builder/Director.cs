using DesignPatterns.ClassLib.Interfaces.Builder;

namespace DesignPatterns.ClassLib.Classes.Builder{
    public class Director{
        public void Construct(IBuilder builder) => builder.BuildParts();
    }
}