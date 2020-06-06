using System;
using System.Collections.Generic;
using System.Globalization;

namespace DataStructures.Strings
{
    /// <summary>
    /// Input: aaabc 
    //Output: abaca

    //Input: aaabb
    //Output: ababa

    //Input: aa
    //Output: Not Possible

    //Input: aaaabc
    //Output: Not Possible
    /// </summary>
    public class ReArrangeCharactersStringNoAdjacent
    {
        public ReArrangeCharactersStringNoAdjacent()
        {
            string[] input = { "aaabc", "aa", "aaaabc","abababa", "abacadae", "kka"};
            ReArrageCharacters(input);
        }

        static Dictionary<char, int> CountTheCharacters(string input)
        {
            var charString = input.ToCharArray();
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            for (int i = 0; i < charString.Length; i++)
            {
                if (keyValuePairs.ContainsKey(charString[i]))
                {
                    int value = keyValuePairs[charString[i]];
                    keyValuePairs.Add(charString[i], value++);
                }
                else
                    keyValuePairs.Add(charString[i], 0);

            }
            return keyValuePairs;
        }

        static void ReArrageCharacters(string[] input)
        {
            foreach(var s in input)
            {
                Dictionary<char,int> keyValuePairs = CountTheCharacters(s);
                
                //Queue<>
            }
        }
    }
}
