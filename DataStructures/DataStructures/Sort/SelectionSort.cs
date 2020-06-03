using System;
namespace DataStructures.Sort
{
    public class SelectionSort
    {
        public SelectionSort()
        {
            Console.WriteLine("\n Print SelectionSort UnSort");
            foreach (var n in (new[] { 5, 7, 1, 2, 8 }))
            {
                Console.Write(n + " ");
            }
            Console.WriteLine("\n Print SelectionSort Sort");
            foreach (var n in SortNumbers(new[] { 5, 7, 1, 2, 8 }))
            {
                Console.Write(n + " ");
            }
        }

        static int[] SortNumbers(int[] unSortedArray)
        {
            int minimumPosition = 0;
            for (int write = 0; write < unSortedArray.Length; write++)
            {
                minimumPosition = write;
                for (int sort = write + 1; sort < unSortedArray.Length; sort++)
                {
                    if (unSortedArray[minimumPosition] > unSortedArray[sort])
                    {
                        int temp = unSortedArray[minimumPosition];
                        unSortedArray[minimumPosition] = unSortedArray[sort];
                        unSortedArray[sort] = temp;
                    }
                }
               
            }
            return unSortedArray;
        }

    }
}
