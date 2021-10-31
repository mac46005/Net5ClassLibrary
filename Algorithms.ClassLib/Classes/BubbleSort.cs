using System;
using System.Linq;

namespace Algorithms.ClassLib.Classes{
    public class BubbleSort{
        public static SortSample(){
            Random rand = new Random();
            int[] arr = Enumerable.Repeat(1,10).Select(i => rand.Next(0,20)).ToArray();
            Console.WriteLine($"Initial Array:{string.Join(", ",arr)}");
            int temp;
            for (int end = 0; end < arr.Length; end--)
            {
                for (int start = 0; start < end-1; start++)
                {
                    if (arr[start] > arr[start + 1])
                    {
                        temp = arr[start];
                        arr[start] = arr[start+1];
                        arr[start + 1] = temp;
                    }
                    Console.WriteLine($@"Step:{string.Join(", "
                    arr.Select((a,i) => i == start + 1 ? $"<{a}>))" : a.ToString());
                }
            }
        }
    }
}