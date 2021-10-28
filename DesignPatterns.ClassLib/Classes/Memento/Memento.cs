using System;

namespace DesignPatterns.ClassLib.Classes.Memento{
    public class Memento<T> where T : ICloneable{
        private T StateObject {get;set;}
        public T GetState(){
            return StateObject;
        }
        public void SetState(T stateObj){
            StateObject = StateObject;
        }
    }
}