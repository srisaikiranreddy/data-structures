using System;
namespace DataStructures.Search
{
    public class LinearSearch
    {
        public LinearSearch()
        {
            Console.WriteLine("\n Print LinearSearchNumbers searchArray { 1,2},findNumbers { 5, 7, 1, 2, 8 }");
            
            Console.WriteLine("\n Print LinearSearchNumbers");
            foreach (var n in LinearSearchNumbers(new[] { 5, 7, 1, 2, 8 }, new[] { 1, 2 }))
            {
                Console.Write(n + " ");
            }
        }

        static int[] LinearSearchNumbers(int[] searchArray, int[] findNumbers)
        {
           int[] numberFound = new int[findNumbers.Length];
           for (int number = 0; number < findNumbers.Length; number++)
           {
                for(int i = 0; i < searchArray.Length; i++)
                {
                    if (findNumbers[number] == searchArray[i])
                    {
                        numberFound[number] = findNumbers[number];
                    }
                }

            }
            return numberFound;
        }

        static string[] LinearSearchWord(string searchWord, string sentence)
        {
            return null;
        }

        static int LinearSearchCountWord(string searchWord, string sentence)
        {
            return 0;
        }

        static int LinearSearchCountChar(string searchWord, char alphabet)
        {
            return 0;
        }

    }
}
