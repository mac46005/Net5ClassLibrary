using System;
using Algorithms.ClassLib.Classes;

namespace TestingConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a sample of an array with 2 rows and 3 elements each
            // also called a matrix
            string[,] textArray = new string[2,3];
            // You can also initialize multidemensional arrays directly
            int[,] intArray = new int[,]{
                {1,2,3},
                {4,5,6}
            };
            // Use the index position to get a value to a multidimensional
            // array element .If there is already a value set for an element, it will
            //be replaced
            //int number = intArray[1,0];
            // To loop through a multidimensional array, you can use the GetUpperBounds()
            // method to get the length of a specific deimension of the array
            for (int row = 0; row < intArray.GetUpperBound(0); row++)
            {
                for (int col = 0; col < intArray.GetUpperBound(0); col++)
                {
                    Console.WriteLine(intArray[row,col]);
                }
            }
            Console.ReadLine();
        }
    }
}
