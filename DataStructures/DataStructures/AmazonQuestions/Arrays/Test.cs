using System;
using System.Collections;

namespace DataStructures.AmazonQuestions.Arrays
{
    public class Test
    {
        public Test()
        {
        }

        public void r(int[] nums)
        {
            Hashtable map = new Hashtable();

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                    map[nums[i]] = Convert.ToInt32(map[nums[i]]) + 1;
                else
                    map.Add(nums[i], 0);
            }

            Queue queue = new Queue();
            foreach (DictionaryEntry pair in map)
            {
                //if (pair.Value > 2)
                //    queue.Dequeue();

            }
        }
    }
}
