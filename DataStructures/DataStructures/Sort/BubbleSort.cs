using System;
namespace DataStructures.Sort
{
    public class BubbleSort
    {
        public BubbleSort()
        {
        }

        static int[] SortNumbers(int[] unSortedArray)
        {
            
                for (int write = 0; write < unSortedArray.Length; write++)
                {
                    for (int sort = write + 1; sort < unSortedArray.Length; sort++)
                    {
                        if (unSortedArray[write] > unSortedArray[sort])
                        {
                            int temp = unSortedArray[write];
                            unSortedArray[write] = unSortedArray[sort];
                            unSortedArray[sort] = temp;
                        }
                    }
                    
                }
               
                return unSortedArray;
        }
    }
}
