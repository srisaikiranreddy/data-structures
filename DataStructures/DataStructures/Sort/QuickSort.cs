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


        static public int Partition(int[] arr, int left, int right)
        {
            int pivot;
            pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }

        }

        static public void quickSort(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    quickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr, pivot + 1, right);
                }
            }
        }
    }
}
