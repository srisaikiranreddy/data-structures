using System;
using System.Collections.Generic;

namespace DataStructures.Strings
{
    public class MakeCheckStringPalindrome
    {
        public MakeCheckStringPalindrome()
        {
            Console.WriteLine("\n Print MakeCheckStringPalindrome Input geeksgk");
            String s = "geeksgk";
            printPalindromePos(s);
        }

        static int MAX = 256;

        static void printPalindromePos(String str)
        {
            // Insert all positions of every 
            // character in the given String. 
            List<int>[] pos = new List<int>[MAX];
            for (int i = 0; i < MAX; i++)
                pos[i] = new List<int>();
            int n = str.Length;
            for (int i = 0; i < n; i++)
                pos[str[i]].Add(i + 1);

            /* find the number of odd elements. 
            Takes O(n) */
            int oddCount = 0;
            char oddChar = (char)0;
            for (int i = 0; i < MAX; i++)
            {
                if (pos[i].Count % 2 != 0)
                {
                    oddCount++;
                    oddChar = (char)i;
                }
            }

            /* A palindrome cannot contain more than 1 
            odd characters */
            if (oddCount > 1)
                Console.Write("NO PALINDROME");

            /* Print positions in first half 
            of palindrome */
            for (int i = 0; i < MAX; i++)
            {
                int mid = pos[i].Count / 2;
                for (int j = 0; j < mid; j++)
                    Console.Write(pos[i][j] + " ");
            }

            // Consider one instance odd character 
            if (oddCount > 0)
            {
                int last = pos[oddChar].Count - 1;
                Console.Write(pos[oddChar][last] + " ");
                pos[oddChar].RemoveAt(pos[oddChar].Count - 1);
            }

            /* Print positions in second half 
            of palindrome */
            for (int i = MAX - 1; i >= 0; i--)
            {
                int count = pos[i].Count;
                for (int j = count / 2; j < count; j++)
                    Console.Write(pos[i][j] + " ");
            }
        }
    }
}
