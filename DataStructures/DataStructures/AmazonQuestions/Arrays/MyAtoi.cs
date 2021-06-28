using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.AmazonQuestions.Arrays
{
    public class MyAtoi
    {
        public MyAtoi()
        {
            MyAtoi1("4193 with words");
        }

        public int MyAtoi1(string s)
        {

            s = s.Replace(" ", String.Empty);
            List<char> chars = new List<char>();
            chars.AddRange(s.ToCharArray());

            StringBuilder result = new StringBuilder();
            if (chars[0] == '+' || chars[0] == '-')
            {
                result.Append(chars[0]);
                chars.RemoveRange(0, 1);
            }
            for (int i = 0; i < chars.Count; i++)
            {
                if (char.IsDigit(chars[i]))
                    result.Append(chars[i]);
                else
                    return 0;
            }

            return Convert.ToInt32(result.ToString());
        }
    }
}
