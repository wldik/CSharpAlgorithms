using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 8, 8, 4, 0, 2, 12, 6, 2, 89, 434, 97, 67 };
            Console.WriteLine(string.Join(", ", array));
            Sorting.InsertionSort(array);
            Console.WriteLine(string.Join(", ", array));
        }
    }
}