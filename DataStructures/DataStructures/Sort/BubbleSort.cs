using System;
namespace DataStructures.Sort
{
    public class BubbleSort
    {
        public BubbleSort()
        {
            Console.WriteLine("\n Print Bubble UnSort");
            foreach (var n in (new[] { 5, 7, 1, 2,8 }))
            {
                Console.Write(n + " ");
            }
            Console.WriteLine("\n Print Bubble Sort");
            foreach (var n in SortNumbers(new []{ 5, 7, 1, 2, 8 }))
            {
                Console.Write(n + " ");
            }
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
