using System;
using System.Linq;

namespace DataStructures.Arrays.Rotation
{
    public class ArrayFindSumPair
    {
        //Input: arr[] = {11, 15, 6, 8, 9, 10}, x = 16
        //Output: true
        //There is a pair(6, 10) with sum 16

        //Input: arr[] = {11, 15, 26, 38, 9, 10}, x = 35
        //Output: true
        //There is a pair(26, 9) with sum 35

        //Input: arr[] = {11, 15, 26, 38, 9, 10}, x = 45
        //Output: false
        //There is no pair with sum 45.

        public ArrayFindSumPair()
        {
            
            Console.WriteLine("ArrayFindSumPair Input:{ 11, 15, 6, 8, 9, 10 } SumPair:16; Output");
            int[] output = SumPair(new[] { 11, 15, 6, 8, 9, 10 }, 16);
            if (output != null && output.Count() > 0)
            { foreach (var n in output)
                {

                    Console.Write(n);
                }
            }

            Console.WriteLine("ArrayFindSumPair Input:{11, 15, 26, 38, 9, 10} SumPair:35; Output");
            output = SumPair(new[] { 11, 15, 26, 38, 9, 10 }, 35);
            if (output != null && output.Count() > 0)
            {
                foreach (var n in output)
                {

                    Console.Write(n);
                }
            }

            Console.WriteLine("ArrayFindSumPair Input:{11, 15, 26, 38, 9, 10} SumPair:45; Output");
            output = SumPair(new[] { 11, 15, 26, 38, 9, 10 }, 45);
            if (output != null && output.Count() > 0)
            {
                foreach (var n in output)
                {

                    Console.Write(n);
                }
            }
            else
                Console.WriteLine("There is no pair with sum");
        }

        static int[] SumPair(int[] input, int sumPair)
        {
            int minimumPosition = 0;
            for (int write = 0; write < input.Length; write++)
            {
                minimumPosition = write;
                for (int sort = write + 1; sort < input.Length; sort++)
                {
                    if (input[minimumPosition] + input[sort] == sumPair)
                    {
                        return new[] { input[minimumPosition], input[sort] };
                    }
                }

            }
            return null;
        }
    }
}
    