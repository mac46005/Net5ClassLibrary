using System;
using Algorithms.ClassLib.Classes;

namespace TestingConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textArray = new string[10];

            int[] intArray = new int[]{1,2,3,4};

            SampleUserDefType[] sampleUserDefTypes = new SampleUserDefType[15];
            textArray[2] = "Text Sample";
            intArray[3] = 3;

            sampleUserDefTypes[1] = new SampleUserDefType(){TextProperty = "text",IntProperty = 42};
            string text = textArray[4];
            int number = intArray[3];

            SampleUserDefType userDefinedElement = sampleUserDefTypes[1];

            for (int i = 0; i < textArray.Length; i++)
            {
                Console.WriteLine(textArray[i]);
            }
            for (int i = 0; i < intArray.GetUpperBound(0); i++)
            {
                Console.WriteLine(textArray[i]);
            }
            for (int i = 0; i < sampleUserDefTypes.GetUpperBound(0); i++)
            {
                Console.WriteLine(sampleUserDefTypes[i]?.TextProperty);
            }
            Console.Read();
        }
    }
}
