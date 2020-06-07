using System;
using System.Linq;

namespace DataStructures.Strings
{
    public class AlternateLowerUpperStringSort
    {
        /// <summary>
        /// Input : bAwutndekWEdkd
        //Output :AbEdWddekkntuw
        //Explanation:
        //Here we can see that letter ‘A’, ’E’, ’W’ are sorted 
        //as well as letters “b, d, d, d, e, k, k, n, t, u, w” are sorted
        //but both appears alternately in the string as far as possible.

        //Input :abbfDDhGFBvdFDGBNDasZVDFjkb
        //Output :BaBaDbDbDbDdDfFhFjFkGsGvNVZ
        /// </summary>
        public AlternateLowerUpperStringSort()
        {
            string[] input = { "bAwutndekWEdkd", "abbfDDhGFBvdFDGBNDasZVDFjkb" };

        }

        static int maxLengthString = 256;

        static void TakeUpperCharLowerChars(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length>maxLengthString)
                return "Empty or maxlenght exceeded";

            char[] inputChars = input.ToCharArray();
            char[] upperChars = new char[maxLengthString];
            char[] lowerChars = new char[maxLengthString];
            for (int i=0;i<inputChars.Count();i++)
            {
                if (Char.IsUpper(inputChars[i]))
                    upperChars[i] = inputChars[i];
                else
                    lowerChars[i] = lowerChars[i];

            }
        }
    }
}
