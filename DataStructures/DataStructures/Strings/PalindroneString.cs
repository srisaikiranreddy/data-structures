using System;
using System.Text;

namespace DataStructures.Strings
{
    public class PalindroneString
    {
        public PalindroneString()
        {
            Console.Write("\n Print PalindroneString Input aba");
            Console.Write("\n"+CheckPalindroneString("aba"));
            Console.Write("\n" + IsPalindrome("A man, a plan, a canal: Panama"));

        }

        static bool CheckPalindroneString(string input)
        {
            char[] inputCharString = input.ToCharArray();
            char[] reverseCharString = input.ToCharArray();
            Array.Reverse(reverseCharString);

            for(int i=0;i<inputCharString.Length;i++)
            {
                if (inputCharString[i] != reverseCharString[i])
                    return false;
            }
            return true;
        }

        public bool IsPalindrome(string s)
        {
            StringBuilder letterNumber = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetterOrDigit(s[i]))
                    letterNumber.Append(s[i]);
            }
            char[] inputCharString = letterNumber.ToString().ToLower().ToCharArray();
            char[] reverseCharString = letterNumber.ToString().ToLower().ToCharArray();
            Array.Reverse(reverseCharString);

            for (int i = 0; i < inputCharString.Length; i++)
            {
                if (inputCharString[i] != reverseCharString[i])
                    return false;
            }
            return true;
        }
    }
}
