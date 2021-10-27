using System;
using DesignPatterns.ClassLib.Interfaces.Factory;

namespace DesignPatterns.ClassLib.Factory{
    public class Middleware1 : IMiddleware{
        //Implementing the interface
        public void DoAction(){
            Console.WriteLine("Executing action from Middleware1");
        }
    }
}