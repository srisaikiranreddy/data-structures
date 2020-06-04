using System;
namespace DataStructures.Queues
{
    /// <summary>
    /// Input: arr[] = {1, 2, 3, 1, 4, 5, 2, 3, 6}, K = 3 
    //Output: 3 3 4 5 5 5 6
    //Explanation: 
    //Maximum of 1, 2, 3 is 3
    //Maximum of 2, 3, 1 is 3
    //Maximum of 3, 1, 4 is 4
    //Maximum of 1, 4, 5 is 5
    //Maximum of 4, 5, 2 is 5 
    //Maximum of 5, 2, 3 is 5
    //Maximum of 2, 3, 6 is 6

    //Input: arr[] = {8, 5, 10, 7, 9, 4, 15, 12, 90, 13}, K = 4 
    //Output: 10 10 10 15 15 90 90
    //Explanation:
    //Maximum of first 4 elements is 10, similarly for next 4 
    //elements(i.e from index 1 to 4) is 10, So the sequence
    //generated is 10 10 10 15 15 90 90
    /// </summary>
    public class MaxSubArraysSize
    {
        public MaxSubArraysSize()
        {
            Console.Write("\n Print MaxSubArraysSize");
            Console.Write("\n Print inputOne { 1, 2, 3, 1, 4, 5, 2, 3, 6 } subArrayOne = 3");
            int[] inputOne = { 1, 2, 3, 1, 4, 5, 2, 3, 6 };
            int subArrayOne = 3;
            Queue(inputOne, subArrayOne);

            Console.Write("\n Print inputTwo { 1, 2, 3, 1, 4, 5, 2, 3, 6 } subArrayTwo = 4");
            int[] inputTwo = { 8, 5, 10, 7, 9, 4, 15, 12, 90, 13 };
            int subArrayTwo = 4;
            Queue(inputTwo, subArrayTwo);

        }

        static int CheckMaxNumberInSubArray(int[] input)
        {
            int maxNumber = 0;
            for(int i=0;i<input.Length; i++)
            {
                if (input[i] > maxNumber)
                    maxNumber = input[i];
            }
            return maxNumber;
        }

        static void Queue(int[] input, int subArraySize)
        {
            Console.Write("\n Print the maxNumber in SubArray");
            
            for(int index=0; index <= input.Length - subArraySize; index++)
            {
                int[] subArray = new int[subArraySize];
                for (int i = index; i< index+subArraySize;i++)
                {
                    int u = index;
                    for (int k = 0;k< subArraySize;k++)
                    {   
                        subArray[k] = input[u];
                        u++;
                    }
                    
                }
                int max = CheckMaxNumberInSubArray(subArray);
                Console.Write(max + " ");
            }
            
        }
    }
}
