using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DataStructures.AmazonQuestions.Recursion
{
//    Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent.Return the answer in any order.

//A mapping of digit to letters (just like on the telephone buttons) is given below.Note that 1 does not map to any letters.
//    Input: digits = "23"
//Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
    public class LetterCombinationsPhoneNumber
    {
        private List<String> combinations = new List<String>();
        private Dictionary<string, string> letters = new Dictionary<string, string>();
            //'2', "abc", '3', "def", '4', "ghi", '5', "jkl",
            //'6', "mno", '7', "pqrs", '8', "tuv", '9', "wxyz" };

        public LetterCombinationsPhoneNumber()
        {
            letters.Add("2", "abc");
            letters.Add("3", "def");
            letters.Add("4", "ghi");
            letters.Add("5", "jkl");
            letters.Add("6", "mno");
            letters.Add("7", "pqrs");
            letters.Add("8", "tuv");
            letters.Add("9", "wxyz");

            Console.Write(LetterCombinations("23"));
        }

        public IList<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();

            if (digits.Length == 0
                || digits == "1"
                || digits == "0"
                || digits == "*"
                || digits == "#")
            {
                return result;
            }

            if (digits.Length == 1)
            {
                var re = letters[digits].ToCharArray();
                foreach(var r in re)
                {
                    result.Add(r.ToString());
                }
                return result;
                
            }

            if(digits.Length >= 0 && digits.Length <=4)
            {
                char[] digit = digits.ToCharArray();

                for(int i=0; i<digit.Length; i++)
                {
                    var first = letters[digit[i].ToString()].ToCharArray();
                    for (int j = i+1; j < digit.Length; j++)
                    {
                        var second = letters[digit[j].ToString()].ToCharArray();
                        foreach(var f in first)
                        {
                            foreach(var s in second)
                            {
                                result.Add(f.ToString()+s.ToString());
                            }
                        }
                    }
                    
                }
            }
            return result;
        }
    }
}
