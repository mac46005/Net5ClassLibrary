using System;
using System.Collections;
using Algorithms.ClassLib.Classes;

namespace TestingConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.ReadLine();
        }
    }
}
