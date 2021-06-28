using System;
namespace DataStructures.AmazonQuestions.Arrays
{
    public class LongestIncreasingSubsequence
    {
        public LongestIncreasingSubsequence()
        {
            LengthOfLIS(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 });
        }

        public int LengthOfLIS(int[] nums)
        {

            int minPosition = 1, counter = 0;
            int minValue = nums[0];

            while (minPosition < nums.Length)
            {
                if (minValue < nums[minPosition])
                    counter++;
                else
                    counter = 0;

                minValue = nums[minPosition];
                minPosition++;
            }
            return counter;
        }
    }
}
