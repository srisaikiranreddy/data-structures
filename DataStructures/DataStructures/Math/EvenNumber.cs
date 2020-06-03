using System;
using System.Collections.Generic;

namespace DataStructures.Math
{
    public class EvenNumber
    {
        public EvenNumber()
        {
            Console.WriteLine("\n Print Even Numbers 1 to 100");
            foreach(var n in GetListEvenNumbers(100))
            {
                Console.Write(n+" ");
            }
        }

        static bool CheckEvenNumber(int N)
        {
            if (N % 2 == 0)
                return true;
            else
                return false;

        }

        static List<int> ListofEvenNumber(List<int> N)
        {
            List<int> evenNumbers = new List<int>();
            foreach (var n in N)
            {
                if (CheckEvenNumber(n))
                    evenNumbers.Add(n);
            }
            return evenNumbers;
        }

        static List<int> GetListEvenNumbers(int N)
        {
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i <= N;i++)
            {
                if(CheckEvenNumber(i))
                    evenNumbers.Add(i);
            }
            return evenNumbers;
        }
    }
}
