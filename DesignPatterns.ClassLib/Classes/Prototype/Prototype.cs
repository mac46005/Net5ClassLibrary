using System;
namespace DesignPatterns.ClassLib.Classes.Prototype{
    public abstract class Prototype : ICloneable{
        public string Prop1 { get; set; }
        public string Prop2 { get; set; }
        
        //When the prototype has referenced types in it
        //you need to be careful about the cloning procedure using shallow copies or Deep copy
        public ProtoTypeDetails ProtoTypeDetails {get;set;}
        public abstract object Clone();
        public override string ToString()
        {
            return $"Prop1: {Prop1} Prop2: {Prop2}";
        }
    }
}