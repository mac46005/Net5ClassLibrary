using System;
<<<<<<< HEAD
using DesignPatterns.ClassLib.Classes.Builder;
using DesignPatterns.ClassLib.Interfaces.Builder;
=======
using System.Collections;
using Algorithms.ClassLib.Classes;
>>>>>>> 3679187a7dd35f9e9b0d9ac94ce9b1c4f6951a1b

namespace TestingConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Director director = new Director();
            IBuilder b1 = new ConcreteBuilder1();
            director.Construct(b1);
            Console.WriteLine(b1.GetProduct());
=======
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Test");
            arrayList.Add(new SampleUserDefType(){IntProperty = 2});
            foreach (var item in arrayList)
            {
                Console.WriteLine(item.GetType());
                if (item is int)
                {
                    Console.WriteLine((int)item);
                }
                else if(item is SampleUserDefType){
                    Console.WriteLine((SampleUserDefType)item);
                }
                else if(item is string){
                    Console.WriteLine(item);
                }
            }
>>>>>>> 3679187a7dd35f9e9b0d9ac94ce9b1c4f6951a1b
            Console.ReadLine();
        }
    }
}
