using System;
namespace DataStructures.Strings
{
    public class PalindroneString
    {
        public PalindroneString()
        {
            Console.Write("\n Print PalindroneString Input aba");
            Console.Write("\n"+CheckPalindroneString("aba"));

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
    }
}
