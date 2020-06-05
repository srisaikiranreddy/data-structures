using System;
namespace DataStructures.Math
{
    public class PalidroneNumber
    {
        public PalidroneNumber()
        {
            Console.Write("\n Print PalindroneString Input 121");
            Console.Write("\n" + CheckPalindroneNumber(121));
        }

        static bool CheckPalindroneNumber(int input)
        {
            int reverseNumber = 0;
            int temp = input;
            while(temp != 0)
            {
                reverseNumber = reverseNumber * 10;
                reverseNumber += (temp % 10);
                temp /= 10;
            }
            if (reverseNumber == input)
                return true;
            else
                return false;
        }
    }
}
