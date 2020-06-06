using System;
using System.Text.RegularExpressions;

namespace DataStructures.Strings
{
    public class RemovePunctuations
    {
        /// <summary>
        /// !"#$%&'()*+,-./:;?@[\]^_`{|}~
        /// Input : %welcome' to @geeksforgeek<s
        //Output : welcome to geeksforgeeks

        //Input : Hello!!!, he said ---and went.
        //Output : Hello he said and went
        /// </summary>
        public RemovePunctuations()
        {
            Console.WriteLine("Print RemovePunctuations:");
            string[] input = { "%welcome' to @geeksforgeek<s", "Hello!!!, he said-- - and went." };
            foreach(var s in input)
            {
                Console.WriteLine("Input:"+s);
                Console.WriteLine("Output:"+RemoveUsingRegex(s));
            }
                
        }

        static string RemoveUsingRegex(string inputString)
        {
            return Regex.Replace(inputString, @"[^\w\d\s]", "");
        }

    }
}
