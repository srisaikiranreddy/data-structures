using System;
using System.Collections.Generic;

namespace DataStructures.AmazonQuestions.Recursion
{
    public class GenerateParentheses
    {
        public GenerateParentheses()
        {
            GenerateParenthesis1(2);
        }

        public IList<string> GenerateParenthesis1(int n)
        {
            List<String> result = new List<String>();
            if (n == 0)
            {
                result.Add("");
            }
            else
            {
                for (int c = 0; c < n; ++c)
                    foreach (var left in GenerateParenthesis1(c))
                        foreach (var right in GenerateParenthesis1(n - 1 - c))
                            result.Add("(" + left + ")" + right);
            }
            return result;

        }
    }
}
