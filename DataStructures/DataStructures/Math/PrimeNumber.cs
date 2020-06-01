using System;
using System.Collections.Generic;

namespace DataStructures.Math
{
    public class PrimeNumber
    {
        public PrimeNumber()
        {
        }

        static bool CheckPrimeNumber(int N)
        {
            int count = 0;
            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                    count++;
            }
            if (count <= 2)
                return true;
            else
                return false;
        }

        static List<int> ListofPrimeNumber(List<int> N)
        {
            List<int> primeNumbers = new List<int>();
            foreach(var n in N)
            {
                if (CheckPrimeNumber(n))
                    primeNumbers.Add(n);
            }
            return primeNumbers;
        }
    }
}
