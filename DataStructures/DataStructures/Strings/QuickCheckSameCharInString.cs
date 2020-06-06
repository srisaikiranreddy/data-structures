using System;
using System.Collections.Generic;

namespace DataStructures.Strings
{
    /// <summary>
    /// Input : s = "geeks"
    //Output : No

    //Input : s = "gggg" 
    //Output : Yes

    /// </summary>
    public class QuickCheckSameCharInString
    {
        public QuickCheckSameCharInString()
        {
            Console.WriteLine("Print QuickCheckSameCharInString:");
            string[] input = { "geeks", "gggg" };
            foreach(var v in input)
            {
                Console.WriteLine("Input:" + v);
                Console.WriteLine("Output:"+CheckSameChar(v).ToString());
            }
        }

        static bool CheckSameChar(string input)
        {
            char[] charInput = input.ToCharArray();
            Queue<char> q = new Queue<char>();
            
            for (int i = 0; i<charInput.Length;i++)
            {
                if (charInput[0] != charInput[i])
                    return false;
            }
            return true;
        }
    }
}
