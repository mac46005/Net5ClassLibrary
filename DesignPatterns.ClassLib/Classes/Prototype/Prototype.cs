using System;
namespace DesignPatterns.ClassLib.Classes.Prototype{
    public abstract class Prototype : ICloneable
    {
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }

}