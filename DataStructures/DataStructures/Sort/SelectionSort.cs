using System;
namespace DataStructures.Sort
{
    public class SelectionSort
    {
        public SelectionSort()
        {
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
