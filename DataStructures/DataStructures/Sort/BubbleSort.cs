using System;
using System.Linq;

namespace DataStructures.Sort
{
    public class BubbleSort
    {
        private int[] _unSortedArray;
        private string _unSortedString;
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
            string input = "qwertyuiopasdfghjklzxcvbnm0987654321~`!@#$%^&*()_-=+{}[]|;'<>?,./";
            Console.WriteLine("\n Print Bubble UnSort String "+ input);
            
            Console.WriteLine("\n Print Bubble Sort String  "+ SortString(input));

            //Input: str = “geeksforgeeks”
            //Output: forggkksseeee
            input = "geeksforgeeks";
            Console.WriteLine("\n Print Bubble UnSort String " + input);

            Console.WriteLine("\n Print Bubble Sort String  " + SortString(input));

        }

        public BubbleSort(int[] unSortedArray, string unSortedString)
        {
            if(unSortedArray.Count() > 0) _unSortedArray = unSortedArray;
            if (!string.IsNullOrEmpty(unSortedString))  _unSortedString = unSortedString;

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

        static string SortString(string unSortedString)
        {
            char[] unSortedStringArray = unSortedString.ToCharArray();
            for (int write = 0; write < unSortedStringArray.Length; write++)
            {
                for (int sort = write + 1; sort < unSortedStringArray.Length; sort++)
                {
                    if (unSortedStringArray[write] > unSortedStringArray[sort])
                    {
                        char temp = unSortedStringArray[write];
                        unSortedStringArray[write] = unSortedStringArray[sort];
                        unSortedStringArray[sort] = temp;
                    }
                }
            }
            return String.Join("",unSortedStringArray);
        }
    }
}
