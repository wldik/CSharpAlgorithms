using System;

namespace Algorithms
{
    class Testing
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 8, 8, 4, 0, 2, 12, 6, 2, 89, 434, 97, 67 };
            Console.WriteLine(string.Join(", ", array));
            Sorting.InsertionSortAscend(array);
            Console.WriteLine(string.Join(", ", array));
            Sorting.InsertionSortDesc(array);
            Console.WriteLine(string.Join(", ", array));
        }
    }
}