using System;
using System.Collections.Generic;

namespace DesignPatterns.ClassLib.Classes.Memento{
    public static class CareTaker<T> where T : ICloneable{
        private static List<Memento<T>> mementoList = new List<Memento<T>>();
        public static void SaveState(Originator<T> orig){
            mementoList.Add(orig.CreateMemento());
        }

        public static void RestoreState(Originator<T> originator,int checkpoint){
            originator.RestoreMemento(mementoList[checkpoint]);
        }
    }
}