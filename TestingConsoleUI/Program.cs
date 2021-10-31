using System;
using Algorithms.ClassLib.Classes;

namespace TestingConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[2][];
            //Use the index position to set a value to a multidimensional array
            //element. If there is already a value set for an element, it will be
            // replaced.
            jaggedArray[0] = new int[]{1,2,3};
            jaggedArray[1] = new int[2];
            jaggedArray[1][0] = 4;
            jaggedArray[1][1] = 5;

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }
            }
            //You can also initialize Jagged arrays directly
            int[][] jaggedArray2 = new int[2][]{
                new int[]{1,2,3},
                new int[]{4,5}
            };
            Console.ReadLine();
        }
    }
}
