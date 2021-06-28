using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.BackTrack
{
    public class PhoneDigits
    {
        public PhoneDigits()
        {
            LetterCombinations("234");
        }

        private List<String> combinations = new List<String>();
        private Hashtable letters = new Hashtable {
            { '2', "abc"},
            { '3', "def"},
            { '4', "ghi"},
            { '5', "jkl"},
            { '6', "mno"},
            { '7', "pqrs"},
            { '8', "tuv"},
            { '9', "wxyz"}
        };

        private String phoneDigits;

        public IList<string> LetterCombinations(string digits)
        {

            if (digits.Length == 0 || digits == "1"
                || digits == "0" || digits == "*" || digits == "#")
            {
                return combinations;
            }

            phoneDigits = digits;
            BackTrack(0, new StringBuilder());
            return combinations;
        }

        private void BackTrack(int index, StringBuilder path)
        {
            // If the path is the same length as digits, we have a complete combination
            if (path.Length == phoneDigits.Length)
            {
                combinations.Add(path.ToString());
                return; // Backtrack
            }

            // Get the letters that the current digit maps to, and loop through them
            String possibleLetters = (string)letters[phoneDigits[index]];
            foreach (char letter in possibleLetters.ToCharArray())
            {
                // Add the letter to our current path
                path.Append(letter);
                // Move on to the next digit
                BackTrack(index + 1, path);
                // Backtrack by removing the letter before moving onto the next
                path.Remove(path.Length - 1, 1);
            }
        }
    }
}
