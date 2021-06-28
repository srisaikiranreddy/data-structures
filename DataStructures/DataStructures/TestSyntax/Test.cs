using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.TestSyntax
{
    class TrieNode
    {
        Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        String word = null;
        public TrieNode() { }
        List<int> rows = new List<int>();
        
    }
    public class Test
    {
        public Test()
        {
            Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
            string s = "";
            string sub = s.Substring(0, 1);
            List<int> rows = new List<int>();
            //rows.Contains();
        }

        //    public void T()
        //    {
        //        StringBuilder builder = new StringBuilder();
        //        string s = "";
        //        s.Split(' ');
        //        foreach (char ch in s.ToCharArray())
        //        {
        //            if (char.IsLetterOrDigit(ch))
        //            {
        //                builder.Append(char.ToLower(ch));
        //            }
        //        }
        //        Convert.ToInt32

        //        String filteredString = builder.ToString();
        //        String reversedString = builder.ToString().Reverse();



        //        Hashtable hashtable = new Hashtable();
        //        hashtable.Values.
        //        foreach (var pair in hashtable.Values)
        //        {
        //            if (Convert.ToInt32(pair) == 1)
        //                return Convert.ToInt32(pair.Key);
        //        }
        //    }
        //    private List<String> combinations = new List<String>();
        //    private Hashtable letters = new Hashtable {
        //    { "2", "abc"},
        //    { "3", "def"},
        //    { "4", "ghi"},
        //    { "5", "jkl"},
        //    { "6", "mno"},
        //    { "7", "pqrs"},
        //    { "8", "tuv"},
        //    { "9", "wxyz"}
        //};

        //    private String phoneDigits;
        //    private void BackTrack(int index, StringBuilder path)
        //    {
        //        // If the path is the same length as digits, we have a complete combination
        //        if (path.Length == phoneDigits.Length)
        //        {
        //            combinations.Add(path.ToString());
        //            return; // Backtrack
        //        }

        //        // Get the letters that the current digit maps to, and loop through them
        //        String possibleLetters = letters[phoneDigits[index]].ToString();
        //        foreach (char letter in possibleLetters.ToCharArray())
        //        {
        //            // Add the letter to our current path
        //            path.Append(letter);
        //            // Move on to the next digit
        //            BackTrack(index + 1, path);
        //            // Backtrack by removing the letter before moving onto the next
        //            path.Remove(path.Length - 1,0);
        //        }
        //    }
    }
}
