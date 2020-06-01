using System;
namespace DataStructures.Search
{
    public class LinearSearch
    {
        public LinearSearch()
        {
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
    }
}
