using System;
//using System.Math;

namespace DataStructures.Strings
{
    public class MaxProbability
    {
        public MaxProbability()
        {
            //int N;
            //double probabilityMax;

            //// 1. N = 1 
            //N = 1;
            //probabilityMax = calculateProbability(N);
            //Console.WriteLine("Maximum Probability for N = "
            //     + N + " is, " +
            ////Math.Round(probabilityMax * 10000.0) / 10000.0);

            //// 2. N = 2 
            //N = 2;
            //probabilityMax = calculateProbability(N);
            //Console.WriteLine("Maximum Probability for N = "
            //     + N + " is, " +
            ////Math.Round(probabilityMax * 10000.0) / 10000.0);

            //// 3. N = 10 
            //N = 10;
            //probabilityMax = calculateProbability(N);
            //Console.WriteLine("Maximum Probability for N = "
            //     + N + " is, " +
            ////Math.Round(probabilityMax * 10000.0) / 10000.0);
        }

        static double calculateProbability(int N)
        {

            // Pmax = N/(N+1) 
            double probability = (double)N / (N + 1);
            return probability;
        }
    }
}
