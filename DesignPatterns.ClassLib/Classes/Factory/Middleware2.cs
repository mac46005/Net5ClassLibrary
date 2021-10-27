using System;
using DesignPatterns.ClassLib.Interfaces.Factory;

namespace DesignPatterns.ClassLib.Factory{
    public class Middleware2 : IMiddleware{
        public void DoAction(){
            Console.WriteLine("An action from Middleware2");
        }
    }
}