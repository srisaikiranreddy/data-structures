using System;
using System.Linq;

namespace DataStructures.Search
{
    public class BinarySearch
    {
        public BinarySearch()
        {
            Console.WriteLine("\n Print BinarySearch searchArray { 1,2,3,4,5 },findNumbers { 1, 7 }");

            Console.WriteLine("\n Print BinarySearch");
            foreach (var n in BinarySearchNumbers(new[] { 1,2,3,4,5 }, new[] { 1, 7 }))
            {
                Console.Write(n + " ");
            }

            Console.WriteLine("\n Print BinarySearch searchArray { 'contribute', 'geeks', 'ide', 'practice' },findNumbers ide,zz, contribute");

            Console.WriteLine("\n Print BinarySearch");
            foreach (var n in BinarySearchString(new[] { "contribute", "geeks", "ide", "practice" }, new[] { "ide", "zz", "contribute" }))
            {
                Console.Write(n + " ");
            }
        }

        static int[] BinarySearchNumbers(int[] searchArray, int[] findNumbers)
        {
            int[] numberFound = new int[findNumbers.Length];
            for (int number = 0; number < findNumbers.Length; number++)
            {
                if (BinarySearchNumbers(searchArray, findNumbers[number], 0, searchArray.Length))
                    numberFound[number] = findNumbers[number];
            }
            return numberFound;
        }

        static string[] BinarySearchString(string[] searchArray, string[] findNumbers)
        {
            string[] numberFound = new string[findNumbers.Length];
            for (int number = 0; number < findNumbers.Length; number++)
            {
                if(BinarySearchString(searchArray, findNumbers[number], 0, searchArray.Length))
                    numberFound[number] = findNumbers[number];
            }
            return numberFound;
        }

        static bool BinarySearchNumbers(int[] searchArray, int searchNumber, int low, int high)
        {
            if(low>=high)
            {
                return false;
            }
            else
            {
                int mid = low + (high - low) / 2;
                if (searchArray[mid] == searchNumber)
                {
                    return true;
                }
                else if(searchNumber < searchArray[mid])
                {
                    return BinarySearchNumbers(searchArray, searchNumber, low, mid - 1);
                }
                else
                {
                    return BinarySearchNumbers(searchArray, searchNumber, mid + 1, high);
                }
            }
        }

        static bool BinarySearchString(string[] searchArray, string searchWord, int low, int high)
        {
            if (low >= high)
            {
                return false;
            }
            else
            {
                int mid = low + (high - low) / 2;
                if (searchArray[mid] == searchWord)
                {
                    return true;
                }
                else if (searchArray[mid].Contains(searchWord))
                {
                    return BinarySearchString(searchArray, searchWord, low, mid - 1);
                }
                else
                {
                    return BinarySearchString(searchArray, searchWord, mid + 1, high);
                }
            }
        }

    }
}
