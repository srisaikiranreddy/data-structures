using System;
namespace DataStructures.Arrays.Rearrangement
{
    public class Array_i__i
    {
        //Input : arr = {-1, -1, 6, 1, 9, 3, 2, -1, 4, -1}
        //Output : [-1, 1, 2, 3, 4, -1, 6, -1, -1, 9]

        //Input : arr = {19, 7, 0, 3, 18, 15, 12, 6, 1, 8,
        //      11, 10, 9, 5, 13, 16, 2, 14, 17, 4}
        //Output : [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
        // 11, 12, 13, 14, 15, 16, 17, 18, 19]
        public Array_i__i()
        {
            Console.WriteLine("Array_i__i Input:{-1, -1, 6, 1, 9, 3, 2, -1, 4, -1} Output");
            int[] output = SortNumbers(new[] { -1, -1, 6, 1, 9, 3, 2, -1, 4, -1 });
            foreach (var n in output)
            {
                Console.Write(n);
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
