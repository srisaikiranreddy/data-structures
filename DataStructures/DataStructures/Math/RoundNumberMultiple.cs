using System;
namespace DataStructures.Math
{
    /// <summary>
    /// Input : 4722
    //Output : 4720

    //Input : 38
    //Output : 40

    //Input : 10
    //Output: 10

    /// </summary>
    public class RoundNumberMultiple
    {
        public RoundNumberMultiple()
        {
            Console.WriteLine("Print RemovePunctuations:");
            Console.WriteLine("Input:" + Round(1234));
        }

        static int Round(int n)
        {
            // Smaller multiple 
            int a = (n / 10) * 10;

            // Larger multiple 
            int b = a + 10;

            // Return of closest of two 
            return (n - a > b - n) ? b : a;
        }
    }
}
