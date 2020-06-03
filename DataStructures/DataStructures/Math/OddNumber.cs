using System;
using System.Collections.Generic;

namespace DataStructures.Math
{
    public class OddNumber
    {
        public OddNumber()
        {
            Console.WriteLine("\n Print Odd Numbers 1 to 100");
            foreach (var n in GetListOddNumbers(100))
            {
                Console.Write(n + " ");
            }
        }

        static bool CheckOddNumber(int N)
        {
            if (N % 2 == 0)
                return true;
            else
                return false;

        }

        static List<int> ListofOddNumber(List<int> N)
        {
            List<int> odd = new List<int>();
            foreach (var n in N)
            {
                if (CheckOddNumber(n))
                    odd.Add(n);
            }
            return odd;
        }

        static List<int> GetListOddNumbers(int N)
        {
            List<int> odd = new List<int>();
            for (int i = 0; i <= N; i++)
            {
                if (CheckOddNumber(i))
                    odd.Add(i);
            }
            return odd;
        }
    }
}
