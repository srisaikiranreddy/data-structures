using System;
using System.Collections;

namespace DataStructures.AmazonQuestions.Arrays
{
    public class RomanToInt
    {
        public RomanToInt()
        {
            RomanToInt1("III");
        }

        public int RomanToInt1(string s)
        {
            Hashtable values = new Hashtable();
            values.Add("I", 1);
            values.Add("V", 5);
            values.Add("X", 10);
            values.Add("L", 50);
            values.Add("C", 100);
            values.Add("D", 500);
            values.Add("M", 1000);
            values.Add("IV", 4);
            values.Add("IX", 9);
            values.Add("XL", 40);
            values.Add("XC", 90);
            values.Add("CD", 400);
            values.Add("CM", 900);

            int sum = 0;
            int i = 0;
            while (i < s.Length)
            {
                if (i < s.Length - 1)
                {
                    String doubleSymbol = s.Substring(i, i + 2);
                    // Check if this is the length-2 symbol case.
                    if (values.ContainsKey(doubleSymbol))
                    {
                        sum += Convert.ToInt32(values[doubleSymbol]);
                        i += 2;
                        continue;
                    }
                }
                // Otherwise, it must be the length-1 symbol case.
                String singleSymbol = s.Substring(i, i + 1);
                sum += Convert.ToInt32(values[singleSymbol]);
                i+=1;
            }
            return sum;
        }
    }
}
