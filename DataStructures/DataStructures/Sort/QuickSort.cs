using System;
namespace DataStructures.Sort
{
    public class QuickSort
    {
        public QuickSort()
        {
            //Console.WriteLine("\n Print QuickSort UnSort");
            //foreach (var n in (new[] { 5, 7, 1, 2, 8 }))
            //{
            //    Console.Write(n + " ");
            //}
            //Console.WriteLine("\n Print QuickSort Sort");
            //int[] unSortedArray = new[] { 5, 7, 1, 2, 8 };
            //foreach (var n in SortNumbers(unSortedArray, unSortedArray.Length, 0,unSortedArray.Length-1))
            //{
            //    Console.Write(n + " ");
            //}
            //string input = "qwertyuiopasdfghjklzxcvbnm0987654321~`!@#$%^&*()_-=+{}[]|;'<>?,./";
            //Console.WriteLine("\n Print Bubble QuickSort String " + input);

            //Console.WriteLine("\n Print QuickSort String  " + SortString(input));
        }

        //static int[] SortNumbers(int[] unSortedArray, int pivot, int left, int right)
        //{

        //}

        //static int Partition(int[] unSortedArray, int pivot, int left, int right)
        //{
        //    int leftPointer = left;
        //    int rightPointer = right;
        //    while (unSortedArray[leftPointer] < unSortedArray[pivot])
        //    {
        //        leftPointer++;
        //    }
        //    while (rightPointer > 0 && unSortedArray[rightPointer] > unSortedArray[pivot])
        //    {
        //        rightPointer--;
        //    }

        //    if(leftPointer>=rightPointer)
        //    {
        //        break;
        //    }
        //    else
        //    {
        //        int temp = unSortedArray[leftPointer];
        //        unSortedArray[leftPointer] = unSortedArray[rightPointer];
        //        unSortedArray[rightPointer] = temp;
        //    }

        //    int temp = unSortedArray[leftPointer];
        //    unSortedArray[leftPointer] = unSortedArray[rightPointer];
        //    unSortedArray[rightPointer] = temp;
        //    return leftPointer;
        //}

        //static string SortString(string unSortedString)
        //{
        //    char[] unSortedStringArray = unSortedString.ToCharArray();
        //    for (int write = 0; write < unSortedStringArray.Length; write++)
        //    {
        //        for (int sort = write + 1; sort < unSortedStringArray.Length; sort++)
        //        {
        //            if (unSortedStringArray[write] > unSortedStringArray[sort])
        //            {
        //                char temp = unSortedStringArray[write];
        //                unSortedStringArray[write] = unSortedStringArray[sort];
        //                unSortedStringArray[sort] = temp;
        //            }
        //        }
        //    }
        //    return String.Join("", unSortedStringArray);
        //}
    }
}
