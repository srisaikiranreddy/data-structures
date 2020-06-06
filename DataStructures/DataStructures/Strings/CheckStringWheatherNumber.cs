using System;
namespace DataStructures.Strings
{
    public class CheckStringWheatherNumber
    {
        public CheckStringWheatherNumber()
        {
            Console.WriteLine("CheckStringWheatherNumber");
            Console.WriteLine("Input string str = 6790;");
            // Saving the input in a string 
            string str = "6790";

            // Function returns 1 if all elements 
            // are in range '0 - 9' 
            if (isNumber(str))
                Console.WriteLine("Integer");

            // Function returns 0 if the 
            // input is not an integer 
            else
                Console.WriteLine("String");
        }

        // Returns true if s is a  
        // number else false 
        static bool isNumber(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (char.IsDigit(s[i]) == false)
                    return false;

            return true;
        }
    }
}
