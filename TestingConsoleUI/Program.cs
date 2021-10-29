using System;
using DesignPatterns.ClassLib.Classes.Builder;
using DesignPatterns.ClassLib.Interfaces.Builder;

namespace TestingConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            IBuilder b1 = new ConcreteBuilder1();
            director.Construct(b1);
            Console.WriteLine(b1.GetProduct());
            Console.ReadLine();
        }
    }
}
