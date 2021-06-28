using System;
namespace DataStructures.AmazonQuestions.Arrays
{
    public class LengthOfLongestSubstring
    {
        public LengthOfLongestSubstring()
        {
            LengthOfLongestSubstring1("abcabcbb");
        }

        public int LengthOfLongestSubstring1(string s)
        {
            if (s == "" || string.IsNullOrEmpty(s)) return 0;

            int num = 0;
            int[] chars = new int[128];
            int staticPointer = 0;
            int movePointer = 0;
            while (movePointer < s.Length)
            {
                char c = s[staticPointer];
                chars[c]++;
                while (chars[c] > 1)
                {
                    char e = s[movePointer];
                    chars[e]--;
                    movePointer++;
                }
                num = System.Math.Max(num, movePointer - staticPointer + 1);

            }
            return num;
        }
    }
}
