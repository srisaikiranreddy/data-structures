using System;
namespace DataStructures.Sort
{
    public class InsertionSort
    {
        public InsertionSort()
        {
            Console.WriteLine("\n Print InsertionSort UnSort");
            foreach (var n in (new[] { 5, 7, 1, 2, 8 }))
            {
                Console.Write(n + " ");
            }
            Console.WriteLine("\n Print InsertionSort Sort");
            foreach (var n in SortNumbers(new[] { 5, 7, 1, 2, 8 }))
            {
                Console.Write(n + " ");
            }
        }

        //Step 1 − If it is the first element, it is already sorted. return 1;
        //Step 2 − Pick next element
        //Step 3 − Compare with all elements in the sorted sub-list
        //Step 4 − Shift all the elements in the sorted sub-list that is greater than the value to be sorted
        //Step 5 − Insert the value
        //Step 6 − Repeat until list is sorted
        static int[] SortNumbers(int[] unSortedArray)
        {
            int holePosition = 0;
            //Looping through array
            for (int write = 0; write < unSortedArray.Length; write++)
            {
                holePosition = write;
                //If the number is first in array. The loop will not execute. 
                //Next iteration there will be numbers  which makes the sub list.
                //The sublist gets sorted first. 
                while (holePosition > 0)
                {
                    if (unSortedArray[holePosition - 1] > unSortedArray[holePosition])
                    {
                        int temp = unSortedArray[holePosition - 1];
                        unSortedArray[holePosition - 1] = unSortedArray[holePosition];
                        unSortedArray[holePosition] = temp;
                    }
                    else
                        break;
                    holePosition--;
                }
            }
            return unSortedArray;
        }  
    }
}
