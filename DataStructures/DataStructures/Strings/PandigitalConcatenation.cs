using System;
using System.Collections.Generic;

namespace DataStructures.Strings
{
    public class PandigitalConcatenation
    {
        public PandigitalConcatenation()
        {
            Console.WriteLine("\n Print PandigitalConcatenation 123567, 098234,14765,19804");
            List<string> v = new List<string>{"123567", "098234", "14765", "19804"};
            Console.WriteLine(countPandigitalPairs(ref v));
        }

        // Checks if a given  
        // string is Pandigital 
        static int isPanDigital(string s)
        {
            int[] digits = new int[10];
            Array.Clear(digits, 0, 10);
            for (int i = 0; i < s.Length; i++)
                digits[s[i] - (int)'0'] = 1;

            // digit i is not present  
            // thus not pandigital  
            for (int i = 0; i <= 9; i++)
                if (digits[i] == 0)
                    return 0;

            return 1;
        }

        // Returns number of pairs 
        // of strings resulting in 
        // Pandigital Concatenations 
        static int countPandigitalPairs(ref List<string> v)
        {
            // iterate over all  
            // pair of strings 
            int pairs = 0;
            for (int i = 0; i < v.Count; i++)
                for (int j = i + 1; j < v.Count; j++)
                    if (isPanDigital(v[i] + v[j]) == 1)
                        pairs++;
            return pairs;
        }
    }
}
