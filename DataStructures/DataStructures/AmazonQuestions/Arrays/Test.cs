using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DataStructures.AmazonQuestions.Arrays
{
    public class Test
    {
        public int Priority { get; set; }
        public int DateStart { get; set; }
        public int DateEnd { get; set; }

        public Test()
        {

            //string[] nums1 = version1.Split("\\.");
            //string[] nums2 = version2.Split("\\.");
            //int n1 = nums1.Length, n2 = nums2.Length;

            //// compare versions
            //int i1, i2;
            //for (int i = 0; i < Math.Max(n1, n2); ++i)
            //{
            //    i1 = i < n1 ? int.Parse(nums1[i]) : 0;
            //    i2 = i < n2 ? int.Parse(nums2[i]) : 0;
            //    if (i1 != i2)
            //    {
            //        return i1 > i2 ? 1 : -1;
            //    }
            //}
            //// the versions are equal
            //return 0;
            PrintOutput();
        }

        //public int CompareVersion(string version1, string version2)
        //{
        //    //string[] nums1 = version1.Split("\\.");
        //    //string[] nums2 = version2.Split("\\.");
        //    //int n1 = nums1.Length, n2 = nums2.Length;

        //    //List<int> vList = new List<string>(map.Values);
        //    //var t = vList.OrderByDescending(i => i).ToArray().Take(2).ToList();

        //    //// compare versions
        //    //int i1, i2;
        //    //for (int i = 0; i < Math.Max(n1, n2); ++i)
        //    //{
        //    //    i1 = i < n1 ? int.Parse(nums1[i]) : 0;
        //    //    i2 = i < n2 ? int.Parse(nums2[i]) : 0;
        //    //    if (i1 != i2)
        //    //    {
        //    //        return i1 > i2 ? 1 : -1;
        //    //    }
        //    //}
        //    //// the versions are equal
        //    //return 0;
        //}

        private string PrintOutput()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("Hello-");

            int[] numbers = new int[10];

            //Time Complexity O(n) // Space Complexity O(1)
            for (int i=0;i<=10;i++)
            {
                numbers[i] = 10 * i + 1;
            }


            if(Priority<90)
            {
                DateStart = 0; DateEnd = 90;
            }
            else if (90< Priority && Priority < 180)
            {
                DateStart = 1000; DateEnd = 5000;
            }
            else
            {
                DateStart = 5000; DateEnd = int.MaxValue;
            }

            return builder.Append(string.Join(",", numbers)).ToString();
        }






    }
}
