using System;
using ConsoleMVCPattern.Interfaces;

namespace ConsoleMVCPattern.Classes{
    public class View : IView
    {
        public int GetID { get; set; }

        public void DisplayId()
        {
            Console.Write(GetID);
        }
    }
}